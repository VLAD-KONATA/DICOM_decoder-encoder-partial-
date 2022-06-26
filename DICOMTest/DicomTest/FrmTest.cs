using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DICOMLib;

namespace DicomTest
{
    public partial class FrmTest : Form
    {
        DCMDataSet ds = new DCMDataSet(new implicitVRLittleEndian());
        DCMFile dcm = new DCMFile();

        public FrmTest()
        {
            InitializeComponent();
        }
        ///<summary>Convert a string of hex digits (ex: E4 CA B2) to a byte array. </summary>  
        ///<param name="s">The string containing the hex digits (with or without spaces).</param>  
        ///<returns>Returns an array of bytes.</returns>  
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");

            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            byte[] data = HexStringToByteArray(txtInput.Text);
            TransferSyntax ts = null;

            if (cbTraferSyntax.SelectedIndex == 0)
                ts = new implicitVRLittleEndian();
            else if (cbTraferSyntax.SelectedIndex == 1)
                ts = new ExplicitVRBigEndian();
            else if (cbTraferSyntax.SelectedIndex == 2)
                ts = new ExplicitVRLittleEndian();
            uint idx = 0;
            DCMAbstractType ds = new DCMDataSet(ts);

            List<DCMAbstractType> items = ds.Parse(data, ref idx);

            LvOutput.Items.Clear();
            foreach (DCMAbstractType item in items)
            {
                string row = item.ToString("");
                string[] subs = row.Split('\n');
                for (int i = 0; i < subs.Length; i++)
                {
                    ListViewItem line = new ListViewItem(subs[i].Split('\t'));
                    LvOutput.Items.Add(line);
                }
            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (dcm.Parse(openFileDialog1.FileName))
                {
                    string data = dcm.ToString("");
                    string[] rows = data.Split('\n');
                    LvOutput.Items.Clear();
                    for (int i = 0; i < rows.Length; i++)
                    {
                        string[] cols = rows[i].Split('\t');
                        ListViewItem item = new ListViewItem(cols);
                        LvOutput.Items.Add(item);
                    }
                }
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            TransferSyntax ts = null;
            if (cbTraferSyntax.SelectedIndex == 0)
                ts = new implicitVRLittleEndian();
            else if (cbTraferSyntax.SelectedIndex == 1)
                ts = new ExplicitVRBigEndian();
            else if (cbTraferSyntax.SelectedIndex == 2)
                ts = new ExplicitVRLittleEndian();
            if (ts == null)
            {
                MessageBox.Show("请选择传输语法", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dcm = new DCMFile(ts);
            //修改或添加文件头元素
            uint n = dcm.filemeta[DicomTags.FileMetaInformationVersion].SetValue<byte[]>(new byte[] { 0, 1 });
            //其它头元素。。。。。。
            n += dcm.filemeta[DicomTags.TransferSyntaxUid].SetValue<string>(dcm.syntax.uid);
            dcm.filemeta[DicomTags.FileMetaInformationGroupLength].SetValue<UInt32>(n);

            //Patient
            //Patient IOM C.7.1.1
            dcm[DicomTags.PatientsName].SetValue<string>("");
            dcm[DicomTags.PatientId].SetValue<string>("");
            dcm[DicomTags.PatientBirthDate].SetValue<string>("");
            dcm[DicomTags.PatientSex].SetValue<string>("");
            
            //Study
            //General Study IOM C.7.2.1
            dcm[DicomTags.StudyInstanceUid].SetValue<string>(tbStudyInstanceUid.Text);
            dcm[DicomTags.StudyDate].SetValue<string>("");
            dcm[DicomTags.StudyTime].SetValue<string>("");
            dcm[DicomTags.ReferringPhysicianName].SetValue<string>("");
            dcm[DicomTags.StudyId].SetValue<string>("");
            dcm[DicomTags.AccessionNumber].SetValue<string>("");
            
            //Series
            //General Series IOM C.7.3.1
            dcm[DicomTags.Modality].SetValue<string>(tbModality731.Text);
            dcm[DicomTags.SeriesInstanceUid].SetValue<string>(tbSeriesInstanceUid.Text);
            dcm[DicomTags.SeriesNumber].SetValue<string>("");
            dcm[DicomTags.Laterality].SetValue<string>("");
            //Parametric Map Series IOM C.8.32.1
            dcm[DicomTags.Modality].SetValue<string>(tbModality8321.Text);
            dcm[DicomTags.SeriesNumber].SetValue<string>(tbSeriesNumber.Text);
            
            //Frame of Reference
            //Frame of Reference IOM C.7.4.1
            dcm[DicomTags.FrameOfReferenceUid].SetValue<string>(tblbFrameOfReferenceUid.Text);
            dcm[DicomTags.PositionReferenceIndicator].SetValue<string>("");
            
            //Equipment
            //General Equipment IOM C.7.5.1
            dcm[DicomTags.Manufacturer].SetValue<string>("");
            //Enhanced General Equipment IOM C.7.5.2
            dcm[DicomTags.Manufacturer].SetValue<string>(tbManufacturer.Text);
            dcm[DicomTags.ManufacturerModelName].SetValue<string>(tbManufacturerModelName.Text);
            dcm[DicomTags.DeviceSerialNumber].SetValue<string>(tbDeviceSerialNumber.Text);
            dcm[DicomTags.SoftwareVersions].SetValue<string>(tbSoftwareVersions.Text);

            //Image
            //General Image IOM C.7.6.1
            dcm[DicomTags.InstanceNumber].SetValue<string>("");
            //Parametric Map Image IOM C.8.32.2
            dcm[DicomTags.ImageType].SetValue<string>(tbImageType.Text);
            dcm[DicomTags.XOffsetInSlideCoordinateSystem].SetValue<string>(tbXOffset.Text);
            dcm[DicomTags.YOffsetInSlideCoordinateSystem].SetValue<string>(tbYOffset.Text);
            dcm[DicomTags.SamplesPerPixel].SetValue<UInt16>(UInt16.Parse(tbSamplesPerPixel.Text));
            dcm[DicomTags.PhotometricInterpretation].SetValue<string>(tbPhotometricInterpretation.Text);
            dcm[DicomTags.BitsAllocated].SetValue<UInt16>(UInt16.Parse(tbBitsAllocated.Text));
            dcm[DicomTags.PresentationLUTShape].SetValue<string>(tbPresentationLUTShape.Text);
            dcm[DicomTags.LossyImageCompression].SetValue<string>(tbLossyImageCompression.Text);
            dcm[DicomTags.BurnedInAnnotation].SetValue<string>(tbBurnedInAnnotation.Text);
            dcm[DicomTags.RecognizableVisualFeatures].SetValue<string>(tbRecognizableVisualFeatures.Text);
            dcm[DicomTags.ContentQualification].SetValue<string>(tbContentQualification.Text);

            //Multi-frame Functional Groups IOM C.7.6.16
            DCMDataSequence sq1 = dcm[DicomTags.SharedFunctionalGroupsSequence] as DCMDataSequence;
            DCMDataItem item1 = new DCMDataItem(dcm.syntax);
            sq1.items.Add(item1);
            DCMDataSequence sq_1 = dcm[DicomTags.PixelMeasuresSequence] as DCMDataSequence;
            item1.items.Add(sq_1);
            DCMDataItem item_1 = new DCMDataItem(dcm.syntax);
            sq_1.items.Add(item_1);
            item_1[DicomTags.PixelSpacing].SetValue<string>(tbPixelSpacing.Text);
            item_1[DicomTags.SliceThickness].SetValue<string>(tbSliceThickness.Text);

            DCMDataItem item3 = new DCMDataItem(dcm.syntax);
            sq1.items.Add(item3);
            DCMDataSequence sq_3 = dcm[DicomTags.PixelValueTransformationSequence] as DCMDataSequence;
            item3.items.Add(sq_3);
            DCMDataItem item_3 = new DCMDataItem(dcm.syntax);
            sq_3.items.Add(item_3);
            item_3[DicomTags.RescaleIntercept].SetValue<string>(tbRescaleIntercept.Text);
            item_3[DicomTags.RescaleSlope].SetValue<string>(tbRescaleSlope.Text);
            item_3[DicomTags.RescaleType].SetValue<string>(tbRescaleType.Text);

            DCMDataItem item4 = new DCMDataItem(dcm.syntax);
            sq1.items.Add(item4);
            DCMDataSequence sq_4 = dcm[DicomTags.FrameVOILUTSequence] as DCMDataSequence;
            item4.items.Add(sq_4);
            DCMDataItem item_4 = new DCMDataItem(dcm.syntax);
            sq_4.items.Add(item_4);
            item_4[DicomTags.WindowCenter].SetValue<string>(tbWindowCenter.Text);
            item_4[DicomTags.WindowWidth].SetValue<string>(tbWindowWidth.Text);

            DCMDataItem item5 = new DCMDataItem(dcm.syntax);
            sq1.items.Add(item5);
            DCMDataSequence sq_5 = dcm[DicomTags.RealWorldValueMappingSequence] as DCMDataSequence;
            item5.items.Add(sq_5);
            DCMDataItem item_5 = new DCMDataItem(dcm.syntax);
            sq_5.items.Add(item_5);
            item_5[DicomTags.RealWorldValueIntercept].SetValue<Double>(Double.Parse(tbRealWorldValueIntercept.Text));
            item_5[DicomTags.RealWorldValueSlope].SetValue<Double>(Double.Parse(tbRealWorldValueSlope.Text));
            item_5[DicomTags.LUTExplanation].SetValue<string>(tbLUTExplanation.Text);
            item_5[DicomTags.LUTLabel].SetValue<string>(tbLUTLabel.Text);
            DCMDataSequence sq_5_5 = dcm[DicomTags.MeasurementUnitsCodeSequence] as DCMDataSequence;
            item_5.items.Add(sq_5_5);
            DCMDataItem item_5_5 = new DCMDataItem(dcm.syntax);
            sq_5_5.items.Add(item_5_5);
            item_5_5[DicomTags.CodeMeaning].SetValue<string>(tbCodeMeaning.Text);
            item_5_5[DicomTags.CodeValue].SetValue<string>(tbCodeValue.Text);
            item_5_5[DicomTags.CodingSchemeDesignator].SetValue<string>(tbCodingSchemeDesignator.Text);
            item_5_5[DicomTags.CodingSchemeVersion].SetValue<string>(tbCodingSchemeVersion.Text);

            DCMDataItem item6 = new DCMDataItem(dcm.syntax);
            sq1.items.Add(item6);
            DCMDataSequence sq_6 = dcm[DicomTags.ParametricMapFrameTypeSequence] as DCMDataSequence;
            item6.items.Add(sq_6);
            DCMDataItem item_6 = new DCMDataItem(dcm.syntax);
            sq_6.items.Add(item_6);
            item_6[DicomTags.FrameType].SetValue<string>(tbFrameType.Text);

            DCMDataSequence sq2 = dcm[DicomTags.PerFrameFunctionalGroupsSequence] as DCMDataSequence;
            DCMDataItem item2 = new DCMDataItem(dcm.syntax);
            sq2.items.Add(item2);
            DCMDataSequence sq_2 = dcm[DicomTags.FrameContentSequence] as DCMDataSequence;
            item2.items.Add(sq_2);
            DCMDataItem item_2 = new DCMDataItem(dcm.syntax);
            sq_2.items.Add(item_2);
            item_2[DicomTags.FrameReferenceDateTime].SetValue<string>(tbFrameReferenceDateTime.Text);
            item_2[DicomTags.FrameAcquisitionDateTime].SetValue<string>(tbFrameAcquisitionDateTime.Text);
            item_2[DicomTags.FrameAcquisitionDuration].SetValue<double>(Double.Parse(tbFrameAcquisitionDuration.Text));
            
            dcm[DicomTags.InstanceNumber].SetValue<string>(tbInstanceNumber.Text);
            dcm[DicomTags.ContentDate].SetValue<string>(tbContentDate.Text);
            dcm[DicomTags.ContentTime].SetValue<string>(tbContentTime.Text);
            dcm[DicomTags.NumberOfFrames].SetValue<string>(tbNumberOfFrames.Text);

            //Multi-frame Dimension IOM C.7.6.17
            DCMDataSequence sq3 = dcm[DicomTags.DimensionOrganizationSequence] as DCMDataSequence;
            DCMDataItem item7 = new DCMDataItem(dcm.syntax);
            sq3.items.Add(item7);
            item4[DicomTags.DimensionOrganizationUid].SetValue<string>(tbDimensionOrganizationUid.Text);

            //Acquisition Context IOM C.7.6.14
            DCMDataSequence sq4 = dcm[DicomTags.AcquisitionContextSequence] as DCMDataSequence;
            DCMDataItem item8 = new DCMDataItem(dcm.syntax);
            sq4.items.Add(item8);

            //SOP Common IOM C.12.1
            dcm[DicomTags.SopClassUid].SetValue<string>(tbSopClassUid.Text);
            dcm[DicomTags.SopInstanceUid].SetValue<string>(tbSopInstanceUid.Text);
            MessageBox.Show("添加成功！");
            string data = dcm.ToString("");
            string[] rows = data.Split('\n');
            LvOutput.Items.Clear();
            for (int i = 0; i < rows.Length; i++)
            {
                string[] cols = rows[i].Split('\t');
                ListViewItem item = new ListViewItem(cols);
                LvOutput.Items.Add(item);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (dcm.Save(saveFileDialog1.FileName, ckUndefined.Checked))
                    MessageBox.Show("保存成功");
            }
        }

        private void btnPic_Print_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage(dcm.GetSet());
            frm.Show();
        }
    }
}

