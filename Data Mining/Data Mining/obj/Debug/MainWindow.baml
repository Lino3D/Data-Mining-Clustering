   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    Data Mining   Data_Mining.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Data Mining��5   	   $��371.111��6   $	��625��6.   $	��400��5       � 
ResizeMode$ CanResizeWithGrip=�5      (   "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5	      +   %MahApps.Metro.Controls.WindowCommands  5
   
   .@�5      �� -   5        $��DocumentButton��5      .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��20��6    $��20��6+   ��5      ��  �� RelativeSource ��  �� AncestorType$ ButtonL� �� Path$ 
Foreground� J� OpacityMask 5      !� 5       j� Stretch$
 Fill=�6*      appbar_page_solid_add	 !� Visual#	 [  5      5      �� 5      $��4 0 0 0q�6    $��Center=�5      $��Add Page��5      5      5      �� 5      -   5        $��MinDistanceTextBox��5       $��25��6   ��6:   ��  �� $ ButtonL�$ 
Foreground�.��6�   5      �� 5      -   5        $��Start��5      {�.  .��5      �� $ 
Horizontal=�6   .+�5      �� $��20��6    $��20��6+   ��5      ��  �� $ ButtonL�$ 
Foreground� 5      !� 5       $
 Fill=�6*     appbar_control_play#	 [ 5!      5#      �� 5$      $��4 0 0 0q�6    $��Center=�5%      $��Start Computation��5&      5'      5(      5-      
   LeftWindowCommands
 5/        50   
   .@�51      �� .��52      �� $ 
Horizontal=�6   .+�53      �� $��20��6    $��20��6+   ��54      ��  �� $ LabelL�$ 
Foreground� 55      !� 56      $
 Fill=�6*     appbar_alien#	 [ 57      59      5:      5;      5<      .��5?      �  � ColumnDefinitions 5@   
   �� 5A      $��0* �6   �� 5B      .+�5D   
   �� $��1��6   $��	10,10,0,0q�6&   .@�5E      �� $��Document��6   .��5F      �  � RowDefinitions 5G      .+�5K      -� -   5        $��FlowDocReader��5K   )     AccentColorBrush#���  6>    -� ViewingMode$ Scroll=�6n    -� IsFindEnabled .   -� IsTwoPageViewEnabled .  
 �� Top$ 50��5M   !    �� Left$ 5��61   5O      5P      �� 5Q      $��	Clustered��6   .��5R      �  5S      �� 5T      $
��549* �6+   �� 5U      $	��52* �6+    5W      �� 5Y      $
��253* �6(   �� 5Z      $	��25* �6(   .+�5^      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5^         AutoGenerateColumns . $��1��6L   $��0��6]   $��2��6j   �� 5`      -   5         ��Name$
 Time��5`      $��0��6*   $��1��6:   #���  6G   $��1��6w   5a      �� 5b      -   5        $��
SaveButton��5b   :   $��1��6   $��1��6*   $��2��6e   .��5c      �� $ 
Horizontal=�6%   .+�5d      �� $��20��6(   $��20��63    J� RenderTransformOrigin$ 24.367,0.204&�5e   j   ��6   ��  �� $ ButtonL�$ 
Foreground� 5f   "   !� 5g   &   $
 Fill=�62     appbar_save#	 [ 5h      5j      5k      5l      5o      5p      5q      5s      5w      