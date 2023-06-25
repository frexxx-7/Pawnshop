using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ломбард.Controls
{
    public partial class TovarControl : UserControl
    {
        public TovarControl(int id, string name, string description, string categoryName)
        {
            InitializeComponent();
            IdLabel.Text = id.ToString();
            NameLabel.Text = name;
            DescriptionLabel.Text = description;
            CategoryLabel.Text = categoryName;
        }
    }
}
