   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM.Views
MVVM.Views  5   	       MVVM.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MVVM.Views     5   	     � Title$  MainView��5   	   $	��450��6   $	��800��6'   .��5	      �� .+�5
   
   �� -   5         ��Name$ 
ListOfCars��5       �� DisplayMemberPath$
 Make��5
   0   $��20q�5   '   $	��150��63   ��5
      �� *Cars+5      �� 5   
   $
��Make��6   $��Center=�6!   �� 5   
   -   5         ��Name$ SelectedCarMakeTextBox��5      $	��200��6x   ��62   �� *SelectedCar.Make+ �� UpdateSourceTrigger$ PropertyChanged=�6x   �� 5   
   $��Model��6   $��Center=�6!   �� 5   
   -   5        $ SelectedCarModelTextBox��5      $	��200��6z   ��63   �� *SelectedCar.Model+$ PropertyChanged=�6z   �� 5   
   $
��Year��6   $��Center=�6    �� 5   
   -   5        $ SelectedCarYearTextBox��5      $	��200��6x   ��62   �� *SelectedCar.Year+$ PropertyChanged=�6x   � 5   
   $��20q�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��Center=�6%      ButtonStyle#��[  6B   $
��Show��6g   ��6v   �� *ShowCommand+�� 5       $��1��6   $��Center=�6%   #��[  6B   $��Delete��6g   ��6x   �� *DeleteCommand+5!      5"      5#      