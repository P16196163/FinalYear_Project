   M S B A M L   `   `   `  ����C  ?CoachAid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CoachAidCoachAid  5      H DCoachAid.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:CoachAid.Core;assembly=CoachAid.CoreCoachAid.Core 5          CoachAid.NewMatchPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:CoachAid     5      Ccore2clr-namespace:CoachAid.Core;assembly=CoachAid.Core     5        N� Title$  NewMatchPage��5
      .��5      �� 
������ $
��Auto=�5      .��5   
   �� 
������ $��5q�5      ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      �� $��0��6   
���   �$��3��5      ._�5      �� $��	New Match��6    
���  ��$��Center=�5       $��Center=�5!         FontSizeLarge#��[  5"       �� Padding$ 20 10q�5#      5$      � 5&      $��1��6    � ColumnDefinitions 5'      �� 5(      �� 5)      �� 5*      .+�5.      �� $��0��6!    �� Orientation$ 
Horizontal=�61   $��Center=�5/   !   $��Center=�50   !   $	��0 4q�51   !   .+�52      �� $��	Opponent:��6$     FontSizeMedium#��[ 65   $
��20 0q�53   $   $��Center=�54   $   �� 55      $��Center=�6"     FontSizeSmall#��[ 56   "   $��2q�57   "   $	��140��58   "   59      �� 5<      $��1��6!   $ 
Horizontal=�61   $��Center=�5=   !   $��Center=�5>   !   $	��0 4q�5?   !   .+�5@      �� $��Venue:��6$   #��[ 62   $
��30 0q�5A   $   $��Bottom=�5B   $   �� 5C      $��Bottom=�6#    �� SelectedIndex$ 0��6>   .@�5D      �� .��6+   Home61   �� 5E      .��6+   Away61   �� 5F      .��6+   	Neutral64   5G      5H      �� 5K      $��2��6!   $ 
Horizontal=�61   $��Center=�5L   !   $��Center=�5M   !   $	��0 4q�5N   !   .+�5O      �� $��Date:��6$   #��[ 61   $
��30 0q�5P   $   $��Center=�5Q   $   (  "System.Windows.Controls.DatePicker  5R      $��Center=�6%   5S      5T      �� 5W      $ 
Horizontal=�6   $��3��66   $��2��5X      $��Center=�5Y      .+�5Z      �� $��Confirm��6     	BaseStyle#��[ 6/   $	��5 2q�5[      $
��10 5q�6*   $��Center=�5\      ��5]      �� *ConfirmCommand+�� 5^      $��Cancel��6   #��[ 6.   $	��5 2q�5_      $
��10 5q�6*   $��Center=�5`      ��5a      �� *CancelCommand+5b      5d      5f      5h      5j      