   M S B A M L   `   `   `  ����K  GMyPrivateFinance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MyPrivateFinanceMyPrivateFinance  5   	   !    MyPrivateFinance.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MyPrivateFinance     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.5* �6   �� 5      $��2* �6   �� 5      $��5* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��4* �6   .+�5   
   o� $��4��6   .@�5      m� -   5        $��FileMenu��5   %   $
��Exit��6   65   m� 5      -   5        $��HelpMenu��5   %   $
��Help��6   65   m� 5      -   5        $��ManageCategories��5   2   $��Manage categories��6   6J   m� 5      -   5        $��Export��5   '   $��Export��6   65   m� 5      -   5        $��
Statistics��5   +   $��
Statistics��6   6=   5      �� 5!   
   $��/Images/Logo.png��6   $��1��6*   $��4��67   &   System.Windows.Controls.DataGrid  5#   
   -   5        $��PaymentGrid��5#      $��2��6&   $��4��63      AutoGenerateColumns .     
IsReadOnly . ��6G   �� *Paymentlist+   Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *Id+6V     5&      $ Category��6%   $ * 6[    67   �� *Categories.Name+6g     5'      $ Description��6%   $ * 6Z    6:   �� *Description+6f     5(      $
 Date��6%   $ * 6L    63   �� *Date+6X     5)      $ Amount��6%   $ * 6P    65   �� *Amount+6\   5+      �� 5-   
   -   5        	 ��Name$		 Add��5-      $	��Add��6   $��4��6,   $��5q�69   6D   �� 5.   
   -   5        $
	 Edit��5.      $
��Edit��6   $��4��6.   $��1��6;   $��5q�6K   6V   �� 5/   
   -	   5        $	 Delete��5/      $��Delete��6!   $��4��62   $��2��6?   $��5q�6O   6Z   �� 51   
   $��	Balance: ��6   $��4��6$   $��4��61   $��Right=�6A   $��Center=�6]   $��	0,0,100,0q�6x   �� 52   
   $��4��6,   $��4��69   $��Right=�6I   $��Center=�6e   $��0,0,50,0q�6�   ��6   �� *	Balance+6�   53      54      