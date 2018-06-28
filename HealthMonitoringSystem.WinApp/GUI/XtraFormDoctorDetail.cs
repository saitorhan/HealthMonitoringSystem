// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDoctorDetail.cs

#region usings

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.DegreeService;
using HealthMonitoringSystem.WinApp.DepartmentService;
using HealthMonitoringSystem.WinApp.DoctorService;
using HealthMonitoringSystem.WinApp.Extensions;
using Doctor = HealthMonitoringSystem.WinApp.DoctorService.Doctor;
using DoctorMail = HealthMonitoringSystem.WinApp.DoctorService.DoctorMail;
using DoctorPhone = HealthMonitoringSystem.WinApp.DoctorService.DoctorPhone;
using ProcessResult = HealthMonitoringSystem.WinApp.DoctorService.ProcessResult;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormDoctorDetail : XtraForm
    {
        private Doctor _doctor;

        private bool update;
        private List<DoctorMail> doctorMails = new List<DoctorMail>();
        private List<DoctorPhone> doctorPhones = new List<DoctorPhone>();

        public XtraFormDoctorDetail()
        {
            InitializeComponent();
        }

        public XtraFormDoctorDetail(Doctor doctor, bool isEditing)
        {
            InitializeComponent();

            this._doctor = doctor;

            textEditTcNumber.Text = _doctor.TcNo;
            textEditTcNumber.Properties.ReadOnly = !isEditing;
            textEditDoctorName.Text = _doctor.Name;
            textEditDoctorName.Properties.ReadOnly = !isEditing;
            textEditDoctorSurname.Text = _doctor.Surname;
            textEditDoctorSurname.Properties.ReadOnly = !isEditing;
            dateEditBirthDay.DateTime = _doctor.BirthDay;
            dateEditBirthDay.Properties.ReadOnly = !isEditing;
            textEditMotherName.Text = _doctor.MotherName;
            textEditMotherName.Properties.ReadOnly = !isEditing;
            textEditFatherName.Text = _doctor.FatherName;
            textEditFatherName.Properties.ReadOnly = !isEditing;
            lookUpEditDegree.EditValue = _doctor.Degree.Id;
            lookUpEditDegree.Properties.ReadOnly = !isEditing;
            lookUpEditDepartmant.EditValue = _doctor.Department.Id;
            lookUpEditDepartmant.Properties.ReadOnly = !isEditing;
            checkEditIsActive.Checked = _doctor.IsActive;
            checkEditIsActive.Properties.ReadOnly = !isEditing;
            doctorPhones = _doctor.DoctorPhones.ToList();
            doctorMails = _doctor.DoctorMails.ToList();

            barButtonItemSaveNewDoctor.Caption = "Güncelle";
            barButtonItemSaveNewDoctor.Enabled = isEditing;

            update = true;
        }

        private void barButtonItemCancelNewDoctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void XtraFormDoctorDetail_Load(object sender, EventArgs e)
        {
            DepartmentSolClient departmentSolClient = Extensions.Extensions.getDepartmentSolClient();
            departmentBindingSource.DataSource = departmentSolClient.Departments(true, false);
            departmentSolClient.Close();
            DegreeSolClient degreeSolClient = Extensions.Extensions.GetDegreeSolClient();
            degreeBindingSource.DataSource = degreeSolClient.Degrees(true);
            degreeSolClient.Close();
            bindingSourceMail.DataSource = doctorMails;
            bindingSourcePhones.DataSource = doctorPhones;

            if (this.Text == "Doktor Detay")
            {
                barButtonItemCancelNewDoctor.Enabled = false;
                textEditMail.Visible = false;
                textEditPhone.Visible = false;
                simpleButtonNewMail.Visible = false;
                simpleButtonNewPhone.Visible = false;
                labelControlMail.Visible = false;
                LabelControlName.Visible = false;
                this.Size = new Size(650, 513);
            }
        }

        private void barButtonItemSaveNewDoctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Doktor kaydediliyor...");
            DoctorSolClient clientDoctor = Extensions.Extensions.GetDoctorSolClient();

            if (clientDoctor == null)
            {
                return;
            }

            if (_doctor == null)
            {
                _doctor = new Doctor
                {
                    TcNo = textEditTcNumber.Text,
                    Name = textEditDoctorName.Text,
                    Surname = textEditDoctorSurname.Text,
                    BirthDay = dateEditBirthDay.DateTime,
                    RegistrationNumber = textEditTcNumber.Text,
                    DegreeId = Convert.ToInt32(lookUpEditDegree.EditValue ?? 0),
                    DepartmentId = Convert.ToInt32(lookUpEditDepartmant.EditValue ?? 0),
                    MotherName = textEditMotherName.Text,
                    FatherName = textEditFatherName.Text,
                    IsActive = checkEditIsActive.Checked,
                    DoctorMails = doctorMails.ToArray(),
                    DoctorPhones = doctorPhones.ToArray()
                };
            }
            else
            {
                _doctor.TcNo = textEditTcNumber.Text;
                _doctor.Name = textEditDoctorName.Text;
                _doctor.Surname = textEditDoctorSurname.Text;
                _doctor.BirthDay = dateEditBirthDay.DateTime;
                _doctor.RegistrationNumber = textEditTcNumber.Text;
                _doctor.DegreeId = Convert.ToInt32(lookUpEditDegree.EditValue ?? 0);
                _doctor.DepartmentId = Convert.ToInt32(lookUpEditDepartmant.EditValue ?? 0);
                _doctor.MotherName = textEditMotherName.Text;
                _doctor.FatherName = textEditFatherName.Text;
                _doctor.IsActive = checkEditIsActive.Checked;
                _doctor.DoctorPhones = doctorPhones.ToArray();
                _doctor.DoctorMails = doctorMails.ToArray();
            }

            ProcessResult processResultDoctor = update ? clientDoctor.Update(_doctor) : clientDoctor.Insert(_doctor);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResultDoctor.Errors, (int) processResultDoctor.Result);

            Close();
        }

        private void checkEditIsActive_CheckedChanged_1(object sender, EventArgs e)
        {
            checkEditIsActive.Text = String.Format("Aktif{0}", checkEditIsActive.Checked ? "" : " Değil");
        }


        private void simpleButtonNewPhone_Click(object sender, EventArgs e)
        {
            if (doctorPhones.Any(p => p.Phone == textEditPhone.Text.Trim()))
                return;

            DoctorPhone phone = new DoctorPhone
            {
                Phone = textEditPhone.Text.Trim(),
                IsActive = true
            };
            doctorPhones.Add(phone);
            gridControlPhones.RefreshDataSource();

            textEditPhone.Text = "";
        }

        private void simpleButtonNewMail_Click(object sender, EventArgs e)
        {
            if (doctorMails.Any(m => m.Mail == textEditMail.Text.Trim())) return;
            DoctorMail mail = new DoctorMail
            {
                Mail = textEditMail.Text.Trim(),
                IsActive = true
            };
            doctorMails.Add(mail);
            gridControlMails.RefreshDataSource();

            textEditMail.Text = "";
        }

        private void gridViewPhones_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            DoctorPhone phone = new DoctorPhone
            {
                Phone = e.CellValue.ToString(),
                IsActive = true
            };

            doctorPhones.Remove(phone);

            gridControlPhones.RefreshDataSource();
            textEditPhone.Text = e.CellValue.ToString();
        }

        private void gridViewMails_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            int handle = e.RowHandle;
            DoctorMail mail = gridViewMails.GetRow(handle) as DoctorMail;

            if (mail.IsNull())
            {
                return;
            }

            doctorMails.Remove(doctorMails.FirstOrDefault(d => d.Id == mail.Id));
            gridControlMails.RefreshDataSource();

            textEditMail.Text = mail.Mail;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
        }
    }
}