   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraryApp.WindowsLibraryApp.Windows  5   	   %    LibraryApp.Windows.ReportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LibraryApp.Windows     5   	     � Title$  ReportWindow��5   	   $	��550��6   $
��1000��6+    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ CanMinimize=�6]   .��5	      � .+�5
   
   �� $��Tarix intervalı seçin :��6   $
��Left=�62   $��	42,30,0,0q�6M   $	��Top=�6`   $	��146��6x   $��14(�6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DtpStart��5      $
��Left=�6'   $��
206,32,0,0q�6B   $	��Top=�6V    J� RenderTransformOrigin$ 0.646,0.211&�6n     5   
   -   5        $ DtpEnd��5      $
��Left=�6%   $��
301,32,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $��Axtar��5      $
��Left=�6!   $��
407,25,0,0q�6<   $	��Top=�6P   $��93��6h   6s   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgvFullOrders��5         AutoGenerateColumns$ False��6*      CanUserAddRows$ False��6F   $��
40,76,40,0q�6]      
IsReadOnly$
 True��6q   $	��266��6�   $	��Top=�6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.10* 6%      Header$ Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5      $
 0.25* 6%   $ Ad��63    6?   �� *Customer.FullName+  5      $
 0.20* 6%   $ Nömrə��63    6B   �� *Customer.PhoneNumber+  5      $
 0.15* 6%   $ Başlama��63    6D   �� *	CreatedAt+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $
 0.15* 6%   $ Bitmə��63    6B   �� *
Deadline+$ {0:dd.MM.yyyy }��  5      $
 0.15* 6%   $ 	Qaytardı��63    6E   �� *
ReturnDate+$ {0:dd.MM.yyyy }��  5      $
 0.15* 6%   $ Ödəniş - ₼��63    6G   �� *
OrderPrice+$ 	{0:0.00 }��  5      $
 0.15* 6%   $ Cərimə - ₼��63    6G   �� *	FinePrice+$ 	{0:0.00 }��5      �� 5   
   $��Kitablar��6   $
��Left=�6#   $��
42,347,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   $��14(�6|   �� 5   
   -   5         ��Name$ TbBooks��5      $
��Left=�6%   $��42,386,0,22q�6@   $
��Wrap=�6U   $	��458��6i   ���	#FFFAFAFA6u   �� 5   
   -   5        $��Excel export ��5      $
��Left=�6)   $��583,386,0,0q�6D   $	��Top=�6Y   $	��127��6q   6}   5      5       