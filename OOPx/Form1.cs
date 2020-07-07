using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeopleCurdRepositorty database = new PeopleCurdRepositorty();
            this.dataGridView.DataSource = database.GetAll();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    class PeopleCurdRepositorty : RepositoryBase<People> { }

    class People : DomainModel
    {
        public People()
        {
        }
        //成员方法  行为


        public void Eat(int foodsize)
        {
            HungerIndex = HungerIndex + foodsize / 2;
        }
        //成员变量
        public int HungerIndex;
        public string IdNumber; //唯一标识符
        public string Name;
        public bool Gender;
        public int Age;
        public DateTime Birthday;
        public string Professional;
    }

}
