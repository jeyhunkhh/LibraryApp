   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraryApp.WindowsLibraryApp.Windows  5   	   *    $LibraryApp.Windows.ActiveOrderWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LibraryApp.Windows     5   	     � Title$  Aktiv Sifarişlər��5   	   $	��550��6"   $	��900��6/    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ CanMinimize=�6`   .��5	      � .+�5
   
   �� -   5         ��Name$ LblCustomerSearch��5
      $��Müştəri axtar : ��6+   $
��Left=�6F   $��	40,20,0,0q�6a   $	��Top=�6t   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5         ��Name$ TxtCustomerSearch��5      $
��Left=�6-   $��
153,22,0,0q�6H    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��142��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DgvOrders��5         AutoGenerateColumns$ False��6&      CanUserAddRows$ False��6B   $��40,76,40,192q�6Y   	   
IsReadOnly$
	 True��6o   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6%      Header$ Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5      $ 0.25* 6%   $ Ad��63    6?   �� *Customer.Name+  5      $ 0.25* 6%   $ Soyad��63    6B   �� *Customer.Surname+  5      $ 0.20* 6%   $ Nömrə��63    6B   �� *Customer.PhoneNumber+  5      $ 0.15* 6%   $ Başlama��63    6D   �� *	CreatedAt+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $ 0.15* 6%   $ Bitmə��63    6B   �� *
Deadline+$ {0:dd.MM.yyyy }��  5      $ 0.15* 6%   $ Toplam - ₼��63    6G   �� *
OrderPrice+$ 	{0:0.00 }��5      �� 5   
   $��Kitablar��6   $
��Left=�6#   $��
40,342,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   $��14(�6|   �� 5   
   -   5         ��Name$ TbBooks��5      $
��Left=�6%   $��
40,374,0,0q�6@   $
��Wrap=�6T   $	��Top=�6i   $	��113��6�   $	��410��6�   ���	#FFFAFAFA6�   5      5      