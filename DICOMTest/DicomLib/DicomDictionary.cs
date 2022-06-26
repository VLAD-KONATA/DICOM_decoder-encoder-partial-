using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DICOMLib
{
    public class DicomDictionary
    {
        List<DicomDictionaryEntry> items = new List<DicomDictionaryEntry>();
        public DicomDictionary()
        {
            string[] lines = System.IO.File.ReadAllLines("dicom.dic");

            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                string[] after = line.Split(new char[] { '\t' });
                if (after[0].Length > 3)
                {
                    //Console.WriteLine("{0},{1},{2},{3},{4},{5}", after[0].Length, after[1], after[2], after[3], after[4], after[5]);
                    string Tag1 = after[0].Substring(2, 4);
                    string Tag2 = after[0].Substring(7, 4);
                    string Name = after[1];
                    string Keyword = after[2].Replace("?", "");
                    string VR = after[3];
                    string VM = after[4];
                    string information = after[5];
                    DicomDictionaryEntry temp = new DicomDictionaryEntry(Tag1, Tag2, Name, Keyword, VR, VM, information);
                    items.Add(temp);
                }
            }

        }
        /// <summary>
        /// 通过Tag查找,返回整个实体
        /// </summary>
        /// <param name="Tag1"></param>
        /// <param name="Tag2"></param>
        /// <returns></returns>
        public DicomDictionaryEntry Find(string gtag, string etag)
        {
            foreach (DicomDictionaryEntry item in items)
            {
                if (item.GTag == gtag && item.ETag == etag)
                {
                    return item;
                }
            }

            return null;
        }

    }

    public class DicomDictionaryEntry
    {
        public string GTag, ETag, Name, Keyword, VR, VM, information; //组合，元素号，Name，Keyword，VR，VM，注释

        public DicomDictionaryEntry(string Tag1, string Tag2, string Name, string Keyword, string VR, string VM, string information)
        {
            this.GTag = Tag1;
            this.ETag = Tag2;
            this.Name = Name;
            this.Keyword = Keyword;
            this.VR = VR;
            this.VM = VM;
            this.information = information;
        }

    }
}