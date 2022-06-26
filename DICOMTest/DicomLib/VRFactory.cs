using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DICOMLib
{
    public class VRFactory
    {
        bool isBE;
        //定义一个Hashtable用于存储享元对象，实现享元池
        private Hashtable VRs = new Hashtable();
        public VRFactory(bool isBE)
        {
            this.isBE = isBE;
        }
        public VR GetVR(string key)
        {
            //如果对象存在，则直接从享元池获取
            if (VRs.ContainsKey(key))
            {
                return (VR)VRs[key];
            }
            //如果对象不存在，先创建一个新的对象添加到享元池中，然后返回
            else
            {
                VR fw = null;
                switch (key)
                {
                    case "SS": fw = new SS(isBE); break;
                    case "US": fw = new US(isBE); break;
                    case "SL": fw = new SL(isBE); break;
                    case "UL": fw = new UL(isBE); break;
                    case "FL": fw = new FL(isBE); break;
                    case "FD": fw = new FD(isBE); break;
                    case "DA": fw = new DA(isBE); break;
                    case "TM": fw = new TM(isBE); break;
                    case "DT": fw = new DT(isBE); break;
                    case "AS": fw = new AS(isBE); break;
                    case "OB": fw = new OB(isBE); break;
                    case "OF": fw = new OF(isBE); break;
                    case "OW": fw = new OW(isBE); break;
                    case "SQ": fw = new SQ(isBE); break;
                    case "UT": fw = new UT(isBE); break;
                    case "UN": fw = new UN(isBE); break;
                    case "AT": fw = new AT(isBE); break;
                    case "CS": fw = new CS(isBE); break;
                    case "PN": fw = new PN(isBE); break;
                    case "UI": fw = new UI(isBE); break;
                    case "IS": fw = new IS(isBE); break;
                    case "DS": fw = new DS(isBE); break;
                    case "AE": fw = new AE(isBE); break;
                    case "SH": fw = new SH(isBE); break;
                    case "LO": fw = new LO(isBE); break;
                    case "ST": fw = new ST(isBE); break;
                    case "LT": fw = new LT(isBE); break;
                    case "US or SS": fw = new US(isBE); break;
                    default:fw = new OB(isBE);break;
                }
                VRs.Add(key, fw);
                return fw;
            }
        }
    }
}