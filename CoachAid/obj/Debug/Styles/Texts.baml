   M S B A M L   `   `   `  ����C  ?CoachAid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CoachAidCoachAid  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   
HeaderText  BaseTextBlockStyle �� BasedOn �� Property  ForegroundMainBrush �� Value  	BaseStyle  FontSizeLarge  LatoRegular  WordBlueBrush  BackgroundVeryLightBrush  ForegroundVeryDarkBrush �� 
TargetType ��Name J� SnapsToDevicePixels ��Name ��Name	 J� IsHitTestVisible

 � Tag 	 LatoThin �� Padding �� Triggers �� Binding �� RelativeSource �� Value �� Triggers P� Property P� Value �� 
TargetName 
 SpinningText  FontAwesome �� 	Resources  Key �� TargetProperty W� From	 W� To g� Duration g� RepeatBehavior �� Self �� Path N� EnterActions ��Name  Spin N� ExitActions �� BeginStoryboardName  PlayerItemContentText  FontSizeMedium  PlayerItemNameText  PlayerItemHeaderText  ForegroundLightBrush�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5       localclr-namespace:CoachAid  5      %�
  &	        7  7  '�� �     7  7  7  7  7  7  7 	 7  &	
 �    7  7  7  &	 �    7  7  7  &	 �	    7  &	 �	    7  7  �� 5      "  ��6   8   .�5   
   ��  � ��8  6'   �� 5   
    � ��$ Center=�6.   �� 5   
    � ��$ Center=�60   �� 5	   
    � ��$	 0 8q�6#   5
      �� 5      "  ��6   8   .�5   
   ��  � ��8  6%   �� 5   
    � ��8  6'   �� 5   
    � ��$ 10q�6$   �� 5   
    � ��$ 0 5 0 5q�6#   �� 5   
    � ��8  6(   �� 5   
    � ��$ 0 0 0 1q�6,   �� 5   
    � ��8  6'   �� 5   
    � ��8  6'   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� $ border��6!   #��z��5   !   #��z��5   !   #��z��5   !    . ._�5!      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5"      �� 5$      $ placeholder��5&   $   	 .  #��z
 5%   $   8�� # z��5(   $   $��Center=�5)   $   #��z��5*   $   8�� ��5.      �� 5/   "   "  ��6(   .�50   &   ��  � y�$ 	Collapsed=�6C    51   &   �� 52   *    66   �� *Text+ �� *TemplatedParent+  6�   .a�53   .   ��  � y�$ Visible=�6K   54   +   56   #   59      5:       5<      P� 5=       � {� .  . �5>      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5?      P� 5@       �@J�IsMouseOver . . �5A      �� $ border��6<    � �� �	#FF7EB4EA6P   5B      P� 5C       �@J�IsKeyboardFocused . . �5D      �� $ border��6<    � �� �	#FF569DE56P   5E      5G      5I      5K      �� 5N      "  ��6   8   .�5O   
   ��  � ��8  6'   �� 5P   
    � ��$	 ༐��6!   �� 5Q   
    �@J�RenderTransformOrigin$ 0.5, 0.5&�62   �� 5R   
    � z� 5S      �� 5T      5V       5X   
   ���� 5Y      Spin .��5Z      W� $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5[      $ 0X�5\      $	 360X�5]      $ 0:0:2D�5^      $ Forever��5_      5`      5a       5c   
   �� 5d       6   �� # Z $ 	IsVisible� True6l    5e      �� 5f      $ SpinStoryboard��6&   8�� 6<    5h      �� 5i      $ SpinStoryboard��6'   5k      5m      �� 5o      "  ��6   8   .�5p   
   ��  � ��8  6'   �� 5q   
    � ��8  6%   �� 5r   
    � ��$ Center=�6.   �� 5s   
    � ��$ Center=�60   �� 5t   
    � ��$ 0q�6#   �� 5u   
    �@��Padding$ 4 2 4 0q�6$   5v      �� 5x      "  ��6   8   .�5y   
   ��  � ��$
 Left=�60   5z      �� 5|      "  ��6   8   .�5}   
   ��  � ��8  6'   5~      5�      