   M S B A M L   `   `   `  ����E  ALibraryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraryApp.WindowsLibraryApp.Windows  5   	   $    LibraryApp.Windows.OrderWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LibraryApp.Windows     5   	     � Title$  Sifariş yarat��5   	   $	��600��6   $
��1200��6,    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ CanMinimize=�6^   .��5	      � .+�5
   
   �� -   5         ��Name$ LblCustomers��5
      $��Müştəri axtar :��6&   $
��Left=�6@   $��	36,32,0,0q�6[   $	��Top=�6n   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ TxtSearchCustomers��5      $
��Left=�6.   $��
145,34,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgvCustomers��5         AutoGenerateColumns$ False��6)      CanUserAddRows$ False��6E   $��36,76,690,279q�6\   	   
IsReadOnly$
	 True��6s   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6%      Header$ Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5      $ 0.25* 6%   $ Ad��63    6?   �� *Name+  5      $ 0.25* 6%   $ Soyad��63    6B   �� *	Surname+  5      $ 0.20* 6%   $ Nömrə��63    6B   �� *PhoneNumber+5      �� 5   
   -   5        $ LblBooks��5      $��Kitab axtar :��6"   $
��Left=�6:   $��
600,32,0,0q�6U   $	��Top=�6i   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $ TxtBookSearch��5      $
��Left=�6)   $��
693,34,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   6�     5   
   -   5        $ DgvBooks��5      $ False��6%   $ False��6A   $
	 True��6X   $��600,75,101,279q�6j   
 5        5      $ 0.10* 6%   $ Id��63    6?   �� *Id+  5      $ 
Kitab adı��6%   $ 0.20* 6Q    68   �� *Name+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 Wrap=�6G   5      5         5!      $ Yazar��6%   $ 0.20* 6O    64   �� *Author+ 5"      �� 5#      " ��6    .�5$      ��  � ��$
 Wrap=�6G   5%      5'        5(      $ 0.11* 6%   $ Qiymət��63    6C   �� *	WeekPrice+ �� StringFormat$ 	{0:0.00 }��  5)      $ 0.10* 6%   $	 Say��63    6@   �� *Count+5+      �� 5-   
   -   5        $ LblCreateDate��5-      $��Kitab götürmə tarixi :��6'   $
��Left=�6H   $��
36,338,0,0q�6c   $	��Top=�6w   $
��Bold"�6�   $��14(�6�   (  "System.Windows.Controls.DatePicker  5.   
   -   5          Name$ DtpCreateDate��5.      $
��Left=�6,   $��194,340,0,0q�6G   $	��Top=�6\   �� 5/   
   -	   5        $ LblDeadline��5/      $��Kitab qaytarma tarixi :��6%   $
��Left=�6G   $��
36,390,0,0q�6b   $	��Top=�6v   $
��Bold"�6�   $��14(�6�     50   
   -
   5        $ DtpDeadline��50      $
��Left=�6*   $��194,392,0,0q�6E   $	��Top=�6Z   �� 51   
   -   5         ��Name$ BtnOrderCreate��51      $��Sifariş yarat��6)   $
��Left=�6A   $��
36,444,0,0q�6\   $	��Top=�6p   $	��179��6�   6�   �� 53   
   -   5         ��Name$ TbSelectedBook��53      $
��Left=�6,   $��600,374,0,0q�6G   $
��Wrap=�6\   $	��Top=�6p   $	��141��6�   $	��499��6�   ���	#FFFAFAFA6�   �� 54   
   $��Seçilən kitablar :��6   $
��Left=�6-   $��600,336,0,0q�6H   $	��Top=�6]   $��14(�6u   $
��Bold"�6�   �� 55   
   -   5        $ BtnOrderView��55      $��Aktiv Sifarişlər��6'   $
��Left=�6B   $��273,444,0,0q�6]   $	��Top=�6r   $	��179��6�   6�   59      5;      