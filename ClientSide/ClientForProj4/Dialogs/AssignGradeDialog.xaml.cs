﻿using LMSLibrary;
using LMSLibrary.Models;
using Project_3___3.Veiw_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Project_3___3.Dialogs
{
    public sealed partial class AssignGradeDialog : ContentDialog
    {
        public AssignGradeDialog(Course course, ObservableCollection<Student> students, AssignmentGroup assignmentGroup, String selected)
        {
            this.InitializeComponent();
            DataContext = new GradeViewModel(course, students, assignmentGroup, selected);
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (StudentList.SelectedItem != null)
            {
                (DataContext as GradeViewModel).AssignGrade(StudentList.SelectedItem.ToString());
            }
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as GradeViewModel).SearchStudents();
        }
    }
}
