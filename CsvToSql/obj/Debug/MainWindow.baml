   M S B A M L   `   `   `  ����  CsvToSql    CsvToSql.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)    � WindowStartupLocation$ CenterScreen=�65   .��5      �� $��10q�6   .+�5	   
   �� $��ConnectionSTring��6   �� 5
   
   -   5         ��Name$ txtConnectionString��5
      $M��Gserver=DESKTOP-S8UOP11\SQLEXPRESS;database=bmf;integrated security=sspi��6/   �� 5   
   $	��CSV��6   � 5   
    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� -   5        $ txtCsv��5      $7��1D:\Trade Quant\Correlação\datasets\ABEV3.SA.csv��6&   �� 5      -   5        $��1��5      $	��...��6%   $��40��63   6>   5      �� 5   
   $��Tabela��6   �� 5   
   -   5        $ 	txtTabela��5      $
��Test��6%   �� 5   
   -   5        $��Execute��5      6#   5      5      