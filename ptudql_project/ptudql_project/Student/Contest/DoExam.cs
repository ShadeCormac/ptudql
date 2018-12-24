using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ptudql_project.Utils;
using ptudql_project.DAO;
using System.IO;
using System.Web.Script.Serialization;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ptudql_project.Student
{
    public partial class DoExam : Form
    {
        
        private DeThi exam;
        private KyThi contest;
        private long maxSecond;
        private long currSecond;
        private string username = Session.AccountName;
        private bool isTrial;
        private bool isSubmited = false;
        private MyTimer timer;

        private List<CauHoi> listQuest;
        private BindingList<CauHoi> blQuests;
        private List<string> listAnsInput;

        private TextBox currentTxtAns;
        private Dictionary<string, TextBox> dictTxtAns = new Dictionary<string, TextBox>();
        private Dictionary<string, RadioButton> dictRdbAns = new Dictionary<string, RadioButton>();

        private Dictionary<string, object> tempData = new Dictionary<string, object>();

        public Action completeExamHandler;

        public DoExam()
        {
            InitializeComponent();
        }

        public DoExam(KyThi _contest, DeThi _exam) : this()
        {
            exam = _exam;
            contest = _contest;

            isTrial = contest.LoaiKyThi == 2;
        }

        private void DoExam_Load(object sender, EventArgs e)
        {
            loadExam();
            loadTVListQuest();
            LoadTempData();
            initTimer();

            if (!isTrial)
            {
                lbGoiY.Visible = false;
                pbGoiY.Visible = false;
            }
        }

        public Dictionary<string, object> LoadJson(string path)
        {
            var jsonStr = File.ReadAllText(path);
            var serializer = new JavaScriptSerializer();
            var json = serializer.Deserialize<Dictionary<string, object>>(jsonStr);

            return json;
        }

        public void LoadTempData()
        {
            maxSecond = (long)exam.ThoiGian * 60;
            currSecond = maxSecond;

            if (contest.LoaiKyThi != 1)
            {
                return;
            }

            string path = $"temp\\{username}_{contest.IDKyThi}_{exam.IdDe}.json";

            if (File.Exists(path))
            {
                var json = LoadJson(path);
                var now = DateTime.Now;
                var timeEnd = DateTime.ParseExact(json["time_end"].ToString(), "dd/MM/yyyy HH:mm:ss", new CultureInfo("en-US", true));

                currSecond = Math.Max((long)Math.Round(timeEnd.Subtract(now).TotalSeconds), 1);
                tempData = json;

                foreach (var item in json)
                {
                    if (item.Key.Contains("ans_input_"))
                    {
                        int idx;
                        string idxStr = item.Key.Substring(item.Key.LastIndexOf("_") + 1);
                        int.TryParse(idxStr, out idx);

                        listAnsInput[idx] = item.Value.ToString();

                        if (!string.IsNullOrEmpty(item.Value.ToString()))
                        {
                            ChangeColorTreeNode(idx);
                        }
                    }
                }
            }
            else
            {
                tempData["time_end"] = DateTime.Now.AddMinutes((double)exam.ThoiGian).ToString("dd/MM/yyy HH:mm:ss");
                tempData["max_quest"] = listQuest.Count;
                SaveTempData();
            }
        }

        public void SaveTempData()
        {
            if (contest.LoaiKyThi != 1)
            {
                return;
            }

            if (!Directory.Exists("temp"))
            {
                Directory.CreateDirectory("temp");
            }
            
            using(var file = File.CreateText($"temp\\{username}_{contest.IDKyThi}_{exam.IdDe}.json"))
            {
                tempData["corrent_ans"] = CorrectAns;
                tempData[$"ans_input_{NumQuest}"] = listAnsInput[NumQuest] == null ? "" : listAnsInput[NumQuest];
                
                var serializer = new JavaScriptSerializer();
                var result = serializer.Serialize(tempData);
                file.WriteAsync(result);
            }
        }
        
        BindingManagerBase bindingManager
        {
            get
            {
                return BindingContext[blQuests];
            }
        }
        

        private void bindText()
        {
            var txtQuestBd = new Binding("Text", blQuests, "NoiDung");
            txtQuestBd.Format += (sender, e) =>
            {
                if (e.DesiredType == typeof(string))
                {
                    e.Value = $"Câu {NumQuest + 1}: {e.Value} ";
                }

            };
            txtQuest.DataBindings.Add(txtQuestBd);
            txtAnsA.DataBindings.Add("Text", blQuests, "CauA");
            txtAnsB.DataBindings.Add("Text", blQuests, "CauB");
            txtAnsC.DataBindings.Add("Text", blQuests, "CauC");
            txtAnsD.DataBindings.Add("Text", blQuests, "CauD");
        }

        private void loadExam()
        {
            dictTxtAns["a"] = txtAnsA;
            dictTxtAns["b"] = txtAnsB;
            dictTxtAns["c"] = txtAnsC;
            dictTxtAns["d"] = txtAnsD;

            dictRdbAns["a"] = rdbAnsAInput;
            dictRdbAns["b"] = rdbAnsBInput;
            dictRdbAns["c"] = rdbAnsCInput;
            dictRdbAns["d"] = rdbAnsDInput;

            if (listQuest == null)
            {
                listQuest = Question.getByDeThi(exam.IdDe);
                blQuests = new BindingList<CauHoi>(listQuest);
                listAnsInput = new List<string>(new string[listQuest.Count]);
                bindText();
            }
        }

        private int NumQuest
        {
            get { return bindingManager.Position; }
            set
            {
                if (value >= 0 && value < listQuest.Count)
                {
                    bindingManager.Position = value;
                    loadAnsInput();
                }
            }
        }

        private void initTimer()
        {
            lbTime.Text = maxSecond.toTimeString();
            timer = new MyTimer(currSecond);
            timer.onMyTimerTick += timer_tick;
            timer.onMyTimerStop += timer_stop;
        }

        private void timer_tick(long second)
        {
            lbTime.Text = second.toTimeString();
            percentBar.Size = new Size((int)(second / (float)maxSecond * percentBar.MaximumSize.Width), 5);
        }

        private void timer_stop(long second)
        {
            if (!isSubmited)
            {
                timer_tick(second);
                MessageBox.Show("Đã hết giờ làm bài", "Thông báo");
                submit();
            }
        }

        private void loadTVListQuest()
        {
            int idx = 0;

            foreach (var quest in listQuest)
            {
                var tn = new TreeNode("Câu " + (idx + 1).ToString());
                tn.Tag = idx;
                tvListQuest.Nodes.Add(tn);
                idx++;
            }

            tvListQuest.ExpandAll();
        }

        private void changeColor(Control control, Color backColor, Color forceColor)
        {
            control.BackColor = backColor;
            control.ForeColor = forceColor;
        }

        private void loadAnsInput()
        {
            string ans = listAnsInput[NumQuest];

            if (isTrial)
            {
                foreach (var txtAns in dictTxtAns)
                {
                    changeColor(txtAns.Value, Color.White, Color.Black);
                }

                if (isSubmited)
                {
                    LoadCorrectAns();
                }
            }

            if (ans != null && ans != string.Empty)
            {
                dictRdbAns[ans].Checked = true;
            }
            else
            {
                foreach (var ansInput in dictRdbAns)
                {
                    ansInput.Value.Checked = false;
                }
            }
        }

        private void tvListQuest_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = e.Node;
            NumQuest = (int)tn.Tag;
        }

        private void LoadCorrectAns()
        {
            var ans = listQuest[NumQuest].CauTLDung;
            changeColor(dictTxtAns[ans.ToString()], Color.Red, Color.White);
        }

        private void goiY_Click(object sender, EventArgs e)
        {
            LoadCorrectAns();
        }

        private void ChangeColorTreeNode(int idx)
        {
            // Doi mau tree view node
            tvListQuest.Nodes[idx].ForeColor = Color.DodgerBlue;
            tvListQuest.Nodes[idx].NodeFont = new Font("Calibri", 12, FontStyle.Bold);
        }

        private void rdbAnsInput_CheckedChanged(object sender, EventArgs e)
        {
            string ans = string.Empty;
            foreach (var ansInput in dictRdbAns)
            {
                if (ansInput.Value.Checked)
                {
                    ans = ansInput.Key;
                }
            }

            if (currentTxtAns != null)
            {
                // Xoa mau text box cu~
                changeColor(currentTxtAns, Color.White, Color.Black);
            }

            if (ans != string.Empty)
            {
                ChangeColorTreeNode(NumQuest);
                // Doi mau text box
                changeColor(dictTxtAns[ans], Color.DodgerBlue, Color.White);
                currentTxtAns = dictTxtAns[ans];
            }

            listAnsInput[NumQuest] = ans;
            SaveTempData();
        }

        private void btnNextQuest_Click(object sender, EventArgs e)
        {
            NumQuest++;
        }

        private void btnPrevQuest_Click(object sender, EventArgs e)
        {
            NumQuest--;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có chắc muốn nộp bài?", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                submit();
            }
        }

        private int CorrectAns
        {
            get
            {
                int correctAns = 0;
                int _maxQuest = listQuest.Count;

                for (var i = 0; i < _maxQuest; i++)
                {
                    string ans = listAnsInput[i];
                    if (ans != string.Empty && ans == listQuest[i].CauTLDung.ToString())
                    {
                        correctAns++;
                    }
                }

                return correctAns;
            }
        }

        private void ShowAns()
        {
            foreach(TreeNode node in tvListQuest.Nodes)
            {
                int idx = (int)node.Tag;
                bool isCorrect = listAnsInput[idx] == listQuest[idx].CauTLDung.ToString();

                node.NodeFont = new Font("Calibri", 12, FontStyle.Bold);
                node.ForeColor = isCorrect ? Color.Green : Color.Red;
            }

            LoadCorrectAns();
        }

        private void DisableInput()
        {
            foreach(var rdb in dictRdbAns)
            {
                rdb.Value.Enabled = false;
            }

            btnSubmit.Enabled = false;
        }

        private void submit()
        {
            if (isSubmited)
            {
                return;
            }

            int _maxQuest = listQuest.Count;
            int _correctAns = CorrectAns;
            float _score = _correctAns / (float)_maxQuest * 10;

            if (Contest.saveContestResult(username, contest.IDKyThi, exam.IdDe, _score, isTrial))
            {
                isSubmited = true;
                timer.Stop();

                DisableInput();

                if (isTrial)
                {
                    ShowAns();
                    panelTips.Visible = true;
                }

                string path = $"temp\\{username}_{contest.IDKyThi}_{exam.IdDe}.json";

                if (!isTrial && File.Exists(path))
                {
                    File.Delete(path);
                }
                
                Router.ShowFormDialog(this, new StudentContestResult(username, contest.IDKyThi, exam.IdDe, _correctAns, _maxQuest));
            }
        }
    }
}
