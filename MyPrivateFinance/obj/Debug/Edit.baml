   M S B A M L   `   `   `  ����K  GMyPrivateFinance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MyPrivateFinanceMyPrivateFinance  5   	       MyPrivateFinance.Edit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MyPrivateFinance     5   	     � Title$
  Edit��5   	   $	��450��6   $	��800��6#   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Amount��6   $��0��6!   $��0��6.   �� 5   
   $��Description��6   $��1��6&   $��0��63   �� 5   
   $��	Categorie��6   $��2��6$   $��0��61   �� 5   
   $
��Date��6   $��3��6   $��0��6,   �� 5   
   $��IsIncome��6   $��4��6#   $��0��60   �� 5   
   -   5        $��AmountTextbox��5      $��0��6(   $��1��65   $��25��6E    �� TextWrapping$
 Wrap=�6Q   $	��120��6e   �� 5   
   -   5        $��DescriptionTextbox��5      $��1��6,   $��1��69   $��25��6I   $
 Wrap=�6U   $	��120��6i   �� 5    
   -   5        $��CategorieComboBox��5    8   $��2��6Q   $��1��6^   $��25��6n   $	��120��6{   ��6   �� *Categorylist+��5!      �� 5"      .R�5#      �� ��6    �� *Name+5$      5&      (  "System.Windows.Controls.DatePicker  5'   
   -   5        $��DateDatePicker��5'      $��3��6+   $��1��68   $��25��6H   $	��120��6U   �� 5(   
   -   5        $��IsIncomeCheckbox��5(      $��4��6+   $��1��68   $��Right=�6I   $��Center=�6e   $��0,0,40,0q�6�   �� 5*   
   -   5         ��Name$
 save��5*      $
��save��6   $��50��6.   $��Right=�69   $��Center=�6U   $��0,0,40,0q�6p   $��5��6�   $��2��6�   6�   5+      5,      