using System.Collections.Generic;
using ptudql_project.Utils;

namespace ptudql_project.DAO
{
    internal class BindingsList<T>
    {
        private List<TaiKhoan> list;

        public BindingsList(List<TaiKhoan> list)
        {
            this.list = list;
        }
    }
}