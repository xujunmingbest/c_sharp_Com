using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace Components
{
    public class Component1 : Component
    {
        private int _id;
        private string _name;
        private DateTime _createDateTime;

        // 在Property窗口中为灰色显示。
        public int Id
        {
            get { return _id; }
        }

        // 在Property窗口中可以设置值。 
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        //在Property窗口中不可见
        public DateTime CreateDateTime
        {
            set { _createDateTime = value; }
        }
    }
}