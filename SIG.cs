using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGW
{
    enum ByteOrder
    {
        Mororola = 0,
        Inter = 1,
    };

    enum ValueType
    {
        unsignedNumber = 0,
        signedNumber = 1,
    };

    public class SIG
    {
        /// <summary>
        /// signal information
        /// </summary>
        string sig_str;//signal txt line string
        string name;
        int startbit;
        int size;
        ByteOrder ebyteorder;
        ValueType evaluetype;
        float factor;
        float offset;
        float min;
        float max;
        string unitstr;
        string receiveNode = "Vector__XXX"; //default value


        public string Sig_str
        {
            get { return sig_str; }
            set { sig_str = value; }
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Startbit
        {
            get { return startbit; }
            set { startbit = value; }
        }


        public int Size
        {
            get { return size; }
            set { size = value; }
        }


        internal ByteOrder Ebyteorder
        {
            get { return ebyteorder; }
            set { ebyteorder = value; }
        }


        internal ValueType Evaluetype
        {
            get { return evaluetype; }
            set { evaluetype = value; }
        }



        public float Factor
        {
            get { return factor; }
            set { factor = value; }
        }


        public float Offset
        {
            get { return offset; }
            set { offset = value; }
        }


        public float Min
        {
            get { return min; }
            set { min = value; }
        }


        public float Max
        {
            get { return max; }
            set { max = value; }
        }



        public string Unitstr
        {
            get { return unitstr; }
            set { unitstr = value; }
        }


        public string ReceiveNode
        {
            get { return receiveNode; }
            set { receiveNode = value; }
        }


    }
}
