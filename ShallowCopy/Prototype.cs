using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopy
{
    abstract class Prototype
    {
        private string _Service;
        private string _Operator;
        private string _Circle;
        private string _Provider;
        public Commission Comm;
        public Prototype(string Ser,string Opr,string Cir,string Pro,Commission Comm)
        {
            this._Service = Ser;
            this._Operator = Opr;
            this._Circle = Cir;
            this._Provider = Pro;
            this.Comm = Comm;
        }

        public string Provider
        {
            get { return _Provider; }
            set { _Provider = value; }
        }
        
        public string Circle
        {
            get { return _Circle; }
            set { _Circle = value; }
        }
        
        public string Operator
        {
            get { return _Operator; }
            set { _Operator = value; }
        }
        
        public string Service
        {
            get { return _Service; }
            set { _Service = value; }
        }


        public abstract Prototype Clone();
    }
}
