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
		public List<string> PeopleList = new List<string>();
		public MainForm()
		{
			InitializeComponent();
		}

	//To Read the Data in the List
		private List<People>GetPeopleList() 
		{
			List<People> PeopleList = new List<People>();

		}
		private void btnLoad_Click(object sender, EventArgs e)
		{
			
			gcPeople.DataSource = PeopleList;	
		}
	//for adding the inputs from the textboxes/combo b
		private void btnAdd_Click(object sender, EventArgs e)
		{
			People people = new People();


			PeopleList.Add(people.FirstName = teFirstName.Text);
			PeopleList.Add(people.MiddleName = teMiddleName.Text);
			PeopleList.Add(people.LastName = teLastName.Text);
			PeopleList.Add(people.Sex = Convert.ToString(cbSex.EditValue));
			PeopleList.Add(people.CivilStatus = Convert.ToString(cbCivilStatus.EditValue));

			XtraMessageBox.Show("Successfully Added!");
		}
	}
}
