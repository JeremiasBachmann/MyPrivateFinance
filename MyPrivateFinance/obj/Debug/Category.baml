   M S B A M L   `   `   `  ����K  GMyPrivateFinance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MyPrivateFinanceMyPrivateFinance  5   	       MyPrivateFinance.Category   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MyPrivateFinance     5   	     � Title$  CreatingCategory��5   	   $	��300��6"   $	��600��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��
Categories��6   $��Bottom=�6%   $
��Left=�6@   $��30,0,0,0q�6[   �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�6#   $��1��6>   $��3��6K   $	��141��6\   $��	30,1,0,10q�6h   ��6{   �� *Categorylist+��5      �� 5      .R�5      � $	��0,2q�6    5      �� 5      $��* �6/   �� 5      $	��100 �6/   .+�5      �� ��6$   �� *Name+5      5       5"      �� 5$   
   -   5        $��textbox��5$      $	��146��6"   $��26��6.   $��1��6:   $��1��6J   $	��Top=�6W   $
��Left=�6o   �� 5%   
   -   5        $	��Add��5%      $��65��6   $��26��6*   $��1��66   $��1��6F   $	��Top=�6S   $
��Left=�6k   $��	176,0,0,0q�6�   6�   �� 5&   
   -   5        $��Delete Selected��5&      $	��226��6+   $��26��67   $��1��6C   $��3��6S   $	��Top=�6`   $
��Left=�6x   6�   5(      5)      