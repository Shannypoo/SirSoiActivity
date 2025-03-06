using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SirSoiActivity
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		List<People> PeopleList = new List<People>();
		public MainForm()
		{
			InitializeComponent();
			
		}

	//Clears the textboxes
		private void Clear() 
		{ 
			teID.Text = teFirstName.Text = teMiddleName.Text = teLastName.Text = cbSex.Text = cbCivilStatus.Text = " ";
			
		
		}
		private void GetPeopleData() 
		{
			gcPeople.DataSource = null;
			gcPeople.DataSource = PeopleList;

		}

	//for adding the inputs from the textboxes/combo box
		private void btnAdd_Click(object sender, EventArgs e)
		{
			People people = new People();
			people.PeopleID = Convert.ToInt32(teID.Text);
			people.FirstName = teFirstName.Text;
			people.MiddleName = teMiddleName.Text;
			people.LastName = teLastName.Text;
			people.Sex = Convert.ToString(cbSex.EditValue);
			people.CivilStatus = Convert.ToString(cbCivilStatus.EditValue);

			PeopleList.Add(people);
			Clear();
			
			XtraMessageBox.Show("Successfully Added!");
			GetPeopleData();
		}
	//deletes the current row being selected
		private void btnDelete_Click(object sender, EventArgs e)
		{
			int forDeletion = Convert.ToInt32(gvPeople.GetFocusedRowCellValue("PeopleID"));

			if (forDeletion > 0 && forDeletion <= PeopleList.Count)
			{

				PeopleList.RemoveAt(Convert.ToInt32(forDeletion - 1));
			}
			GetPeopleData();
		}
	//Updates the current row being focused
		private void btnUpdate_Click(object sender, EventArgs e)
		{

			int IndexToEdit = Convert.ToInt32(gvPeople.GetFocusedRowCellValue("PeopleID"));

			var person = PeopleList.FirstOrDefault(p => p.PeopleID == IndexToEdit);

			if (person != null)
			{
				
				person.PeopleID = Convert.ToInt32(teID.Text);
				person.FirstName = teFirstName.Text;
				person.MiddleName = teMiddleName.Text;
				person.LastName = teLastName.Text;
				person.Sex = Convert.ToString(cbSex.EditValue);
				person.CivilStatus = Convert.ToString(cbCivilStatus.EditValue);
				
				GetPeopleData();
				XtraMessageBox.Show("Successfully Updated!");
			}
			else
			{
				XtraMessageBox.Show("Person not found!");
			}
			Clear();

		}
		//It puts the data inside the focused row into the corresponding textedits.
		private void gvPeople_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (gvPeople.FocusedRowHandle >= 0) // Ensure a valid row is selected
			{
				teID.Text = Convert.ToString(gvPeople.GetFocusedRowCellValue("PeopleID"));
				teFirstName.Text = Convert.ToString(gvPeople.GetFocusedRowCellValue("FirstName"));
				teMiddleName.Text = Convert.ToString(gvPeople.GetFocusedRowCellValue("MiddleName"));
				teLastName.Text = Convert.ToString(gvPeople.GetFocusedRowCellValue("LastName"));
				cbSex.EditValue = gvPeople.GetFocusedRowCellValue("Sex");
				cbCivilStatus.EditValue = gvPeople.GetFocusedRowCellValue("CivilStatus");
			}
		}
	}
}
