   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraryApp.WindowsLibraryApp.Windows  5   	   -    'LibraryApp.Windows.ViewReturnBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LibraryApp.Windows     5   	     � Title$  Kitab qaytarmaları izlə��5   
   $	��600��6*   $
��1000��67    � WindowStartupLocation$ CenterScreen=�6D    � 
ResizeMode$ CanMinimize=�6i   .��5	      � .+�5
   
   � $��	0,0,750,0q�6   .+�5      �� -   5         ��Name$ BtnTodayReturn��5      $��Bugün qaytaranlar��6-   $��Center=�6I   $��0,65,0,0q�6f   $	��Top=�6x   $	��186��6�   6�   �� 5      -   5        $ BtnTomorrowReturn��5      $��Sabah qaytaranlar��60   $��Center=�6L   $��	0,121,0,0q�6i   $	��Top=�6|   $	��186��6�   6�   �� 5      -   5        $ BtnLateReturn��5      $��Gecikmələr��6,   $��Center=�6A   $��	0,179,0,0q�6^   $	��Top=�6q   $	��186��6�   6�   5      � 5   
   -   5         �Name$ 	gridToday��5      $��	250,0,0,0q�6"   $y�Visible=�65   .+�5      �� $��Bugün qaytaranlar��6   $
��Left=�60   $��	10,23,0,0q�6K   $	��Top=�6^    J� RenderTransformOrigin$ 0.167,0.544&�6v   $	��182��6�   $��18(�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DgvTodayReturn��5         AutoGenerateColumns$ False��6/      CanUserAddRows$ False��6K   	   
IsReadOnly$
	 True��6b   $��0,65,36,209q�6t   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $ 0.25* 6)   $ Ad��67    6C   �� *Customer.Name+  5      $ 0.25* 6)   $ Soyad��67    6F   �� *Customer.Surname+  5      $ 0.20* 6)   $ Nömrə��67    6F   �� *Customer.PhoneNumber+  5      $ 0.15* 6)   $ Başlama��67    6H   �� *	CreatedAt+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $ 0.15* 6)   $ Bitmə��67    6F   �� *
Deadline+$ {0:dd.MM.yyyy }��5      �� 5      $��Kitablar : ��6   $
��Left=�6*   $��
10,375,0,0q�6E   $	��Top=�6Y   $��14(�6q   $
��Bold"�6   �� 5      -   5         ��Name$ TbTotayBooks��5      $
��Left=�6.   $��	0,412,0,0q�6I   $
��Wrap=�6\   $	��Top=�6p   $	��135��6�   $	��452��6�   ���	#FFFAFAFA6�   5      � 5   
   -   5        $ gridTomorrow��5      $��	250,0,0,0q�6%   $y�Hidden=�68   .+�5       �� $��Sabah qaytaranlar��6   $
��Left=�60   $��	10,23,0,0q�6K   $	��Top=�6^   $ 0.167,0.544&�6v   $	��182��6�   $��18(�6�   $
��Bold"�6�     5!      -   5        $ DgvTomorrowReturn��5!      $ False��62   $ False��6N   $
	 True��6e   $��0,65,36,209q�6w   
 5"        5#      $ 0.10* 6)   $ Id��67    6C   �� *Id+  5$      $ 0.25* 6)   $ Ad��67    6C   �� *Customer.Name+  5%      $ 0.25* 6)   $ Soyad��67    6F   �� *Customer.Surname+  5&      $ 0.20* 6)   $ Nömrə��67    6F   �� *Customer.PhoneNumber+  5'      $ 0.15* 6)   $ Başlama��67    6H   �� *	CreatedAt+$ {0:dd.MM.yyyy }��  5(      $ 0.15* 6)   $ Bitmə��67    6F   �� *
Deadline+$ {0:dd.MM.yyyy }��5*      �� 5+      $��Kitablar : ��6   $
��Left=�6*   $��
10,375,0,0q�6E   $	��Top=�6Y   $��14(�6q   $
��Bold"�6   �� 5,      -	   5        $ TbTomorrowBooks��5,      $
��Left=�61   $��	0,412,0,0q�6L   $
��Wrap=�6_   $	��Top=�6s   $	��135��6�   $	��452��6�   ���	#FFFAFAFA6�   5-      � 5.   
   -
   5        $ gridLate��5.      $��	250,0,0,0q�6!   $y�Hidden=�64   .+�5/      �� $��Gecikmələr��6   $
��Left=�6)   $��	10,23,0,0q�6D   $	��Top=�6W   $ 0.167,0.544&�6o   $	��182��6�   $��18(�6�   $
��Bold"�6�     50      -   5        $ DgvLateReturn��50      $ False��6.   $ False��6J   $
	 True��6a   $��0,65,36,209q�6s   
 51        52      $ 0.10* 6)   $ Id��67    6C   �� *Id+  53      $ 0.25* 6)   $ Ad��67    6C   �� *Customer.Name+  54      $ 0.25* 6)   $ Soyad��67    6F   �� *Customer.Surname+  55      $ 0.20* 6)   $ Nömrə��67    6F   �� *Customer.PhoneNumber+  56      $ 0.15* 6)   $ Başlama��67    6H   �� *	CreatedAt+$ {0:dd.MM.yyyy }��  57      $ 0.15* 6)   $ Bitmə��67    6F   �� *
Deadline+$ {0:dd.MM.yyyy }��59      �� 5:      $��Kitablar : ��6   $
��Left=�6*   $��
10,375,0,0q�6E   $	��Top=�6Y   $��14(�6q   $
��Bold"�6   �� 5;      -   5        $ TbLaleBooks��5;      $
��Left=�6-   $��	0,412,0,0q�6H   $
��Wrap=�6[   $	��Top=�6o   $	��135��6�   $	��452��6�   ���	#FFFAFAFA6�   5<      5=      5>      