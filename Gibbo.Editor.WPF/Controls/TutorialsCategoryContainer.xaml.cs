﻿#region Copyrights
/*
Gibbo2D License - Version 1.0
Copyright (c) 2013 - Gibbo2D Team
Founders Joao Alves <joao.cpp.sca@gmail.com> & Luis Fernandes <luisapidcloud@hotmail.com>

Permission is granted to use this software and associated documentation files (the "Software") free of charge, 
to any person or company. The code can be used, modified and merged without restrictions, but you cannot sell 
the software itself and parts where this license applies. Still, permission is granted for anyone to sell 
applications made using this software (for example, a game). This software cannot be claimed as your own, 
except for copyright holders. This license notes should also be available on any of the changed or added files.

The software is provided "as is", without warranty of any kind, express or implied, including but not limited to 
the warranties of merchantability, fitness for a particular purpose and non-infrigement. In no event shall the 
authors or copyright holders be liable for any claim, damages or other liability.

The license applies to all versions of the software, both newer and older than the one listed, unless a newer copy 
of the license is available, in which case the most recent copy of the license supercedes all others.

*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gibbo.Editor.WPF
{
    /// <summary>
    /// Interaction logic for TutorialsCategoryContainer.xaml
    /// </summary>
    public partial class TutorialsCategoryContainer : UserControl
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructors

        public TutorialsCategoryContainer()
        {
            InitializeComponent();
        }

        public TutorialsCategoryContainer(string category)
        {
            InitializeComponent();

            CategoryTextBlock.Text = "● " + category;
        }

        #endregion

        #region Methods

        public bool AddTutorialPreview(string xmlPath, string rootPath)
        {
            TutorialContainer tutoPreview = new TutorialContainer(xmlPath, rootPath);
            if (tutoPreview.ReadInfo())
            {
                this.TutorialsWrapPanel.Children.Add(tutoPreview);
                return true;
            }

            return false;
        }

        #endregion
    }
}
