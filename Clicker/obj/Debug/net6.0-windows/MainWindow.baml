   M S B A M L   `   `   `  ����B  >Clicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ClickerClicker  5   	       Clicker.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Clicker     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
         Clicker.ViewModelBase  5   
    � 	Resources 5      ��%    5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��3* �6   6,   �� 5      6!    � RowDefinitions 5   
   �� 5      $��3* �6   6*   �� 5      $��2* �6   6*   .+�5   
   ��  �� ContentStringFormat$ Liczba Kliknięć: {0}��6   $��0��6;   $��0��6H   $��24(�6~   $
��Bold"�6�   $$��Bahnschrift SemiBold Condensed)�6�   ���	#FFB1AEAE��6X   �� *MainCounter.Count+6�   �� 5   
   $ Łącznie: {0}��6   $��0��63   $��2��6@   $��24(�6{   $
��Bold"�6�   $$��Bahnschrift SemiBold Condensed)�6�   ���	#FFB1AEAE$��Stretch=�6�   ��6P   �� *MainCounter.TotalCount+6�   �� 5   
   $��0��6   $��1��6   $��2��6O    � Cursor$  ��6`   ��6.   �� *ClickCommand+.��5      �� $��
/kilof.png��6   $
��Fill=�6(   5       �� 5#   
   $��2��6   $��0��6   $��Stretch=�6-   $	��Top=�6K   $$��Bahnschrift SemiBold Condensed)�6�   $
��Bold"�6�   ���	#FF9FA4A3$��20(�6�   ��6c   �� *DoubleClick.Name+6�   �� 5$   
   $��2��6   $��0��6   $��Stretch=�6-   $��Bottom=�6K   $ Kupiono: {0}��6�   $$��Bahnschrift SemiBold Condensed)�6�   $
��Bold"�6�   ���	#FFFF8E8E$��20(�6  ��6f   �� *DoubleClick.Count+6  �� 5%   
   $��2��6   $��0��6   $��Stretch=�6/   $��Center=�6M   
���/���$ 
Koszt: {0}��6�   $	��160��6  $	��110��6  $$��Bahnschrift SemiBold Condensed)�6(  $
 Hand��6T  ��6h   �� *DoubleClick.Cost+��6�   �� *
BuyCommand+��6�   �� *DoubleClick+6T  �� 5'   
   $��1��6   $��2��6   $��Stretch=�6-   $	��Top=�6K   $$��Bahnschrift SemiBold Condensed)�6�   $��20(�6�   $
��Bold"�6�   ���	#FF9FA4A3��6c   �� *IdleClick.Name+6�   �� 5(   
   $��2��6   $��2��6   $��Stretch=�6-   $��Bottom=�6K   $ Kupiono: {0}��6�   $$��Bahnschrift SemiBold Condensed)�6�   $
��Bold"�6�   ���	#FFFF8E8E$��20(�6  ��6f   �� *IdleClick.Count+6  �� 5)   
   $��2��6   $��2��6   $��Stretch=�6/   $��Center=�6M   
���/���$ 
Koszt: {0}��6�   $	��160��6  $	��110��6  $$��Bahnschrift SemiBold Condensed)�6$  $
 Hand��6P  ��6h   �� *IdleClick.Cost+��6�   �� *
BuyCommand+��6�   �� *	IdleClick+6P  5-      5.      