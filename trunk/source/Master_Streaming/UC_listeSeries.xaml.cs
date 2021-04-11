﻿using System;
using System.Collections.Generic;
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

namespace Master_Streaming
{
    /// <summary>
    /// Logique d'interaction pour UC_listeSeries.xaml
    /// </summary>
    public partial class UC_listeSeries : UserControl
    {
        public UC_listeSeries()
        {
            InitializeComponent();
            filtrage.SelectedIndex = 0; //valeur par défaut de la combobox du filtrage
            trie.SelectedIndex = 0; //valeur par défaut de la combobox du trie
        }
    }
}