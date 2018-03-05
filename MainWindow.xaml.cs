/*
 * Aiden Jolley Ruhn
 * March 5, 2018
 * U1_CareersAidenJ
 * Careers AidenJ - Displays all information based on Guelph University regarding their Software Engineering course that is displayed in a user-friendly web based Treeview
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U1_CareersAidenJ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Web.Navigate("https://admission.uoguelph.ca/bcomp/se");
        }

        private void Web_Navigating(object sender, NavigatingCancelEventArgs e)
        {
       
        }
        // From Here On Down Are The Buttons For Info
        private void CarrDet_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Potential Future Section
        {
            Web.Navigate("https://www.recruitguelph.ca/cecs/software-engineering");


        }

        private void ResLct_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Lifestyle Section
        {
            Web.Navigate("https://www.uoguelph.ca/campus/map/");
        }

        private void CmpLife_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Lifestyle Section 
        {
            Web.Navigate("http://reslife.uoguelph.ca/");
        }

        private void Prereq_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Requirements Section
        {
            Web.Navigate("https://admission.uoguelph.ca/ontariosubreqs");

        }

        private void PrgInf_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Information Section 
        {
            Web.Navigate("https://www.uoguelph.ca/registrar/calendars/undergraduate/current/c10/c10bcomp-seng.shtml");
        }

        private void CmpFct_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Information Section
        {
            Web.Navigate("");
        }

        private void SchInf_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Information Section
        {
            Web.Navigate("https://www.uoguelph.ca/");
        }

        private void TuiCst_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Information Section
        {
            Web.Navigate("https://www.uoguelph.ca/registrar/studentfinance/apps/tuition?level=ug&year=2018&semester=win&cohort=2017&campus=uofg&feepage=canft");
        }

        private void ResCst_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Information Section 
        {
            Web.Navigate("http://housing.uoguelph.ca/residence-fees");

        }

        private void Web_Navigated(object sender, NavigationEventArgs e)
        {
    
        }

    }
}
