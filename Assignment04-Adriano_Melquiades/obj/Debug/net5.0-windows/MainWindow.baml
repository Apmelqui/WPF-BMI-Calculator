   M S B A M L   `   `   `  ����Z  VAssignment04-Adriano_Melquiades, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Assignment04_Adriano_MelquiadesAssignment04_Adriano_Melquiades  5   	   0    *Assignment04_Adriano_Melquiades.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Assignment04_Adriano_Melquiades     5   	     � Title$  
MainWindow��5   	    � SizeToContent$ WidthAndHeight=�6   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��20,20,10,11q�6%   .+�5      �� $��1q�6   
���   �.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��100��6   $��60��6(   $����C:\Users\apmel\OneDrive\IDEs\Visual-Studio-Files\C#\CentennialProgramming02\Assignment04-AdrianoMelquiades\Assignment04-Adriano_Melquiades\img\startImage.jpg��64   �� 5      $��BMR Calculator��6   $��38(�65   5      5      �� 5      $��1q�6   
���   �.��5      �� $	��300��6   .+�5%      �� $'��!Please select a unit system below��6   6J   �� 5&      -   5        $��comboBox��5&      .@�5'      �� -   5        $��comboMetric��5'   '   $��Metric - (meters - Kg)��6:   6^   �� 5(      -   5        $��comboImperial��5(   '   $��Imperial (inches - pounds��6<   6b   5)      	� 50      -   5        $��	radioMale��50   G   $��0 10 0 0q�6"    	� 	GroupName$ gender��64   .��6X   Male6^   	� 51      -   5        $��radioFemale��51   5   $ gender��6"   .��6H   Female6P   �� 55      $	��Age��6    $	��150��6+   $��0 0 0 10q�67   �� 56      -   5        $��txtAge��56      $	��150��6,   
�������$��0 0 0 20q�6K   �� 58      $��Height��6    $	��150��6.   $��0 0 0 10q�6:   �� 59      -   5        $��	txtHeight��59      $	��150��6/   
�������$��0 0 0 20q�6N   �� 5;      $��Weight��6    $	��150��6.   $��0 0 0 10q�6:   �� 5<      -   5        $��	txtWeight��5<      $	��150��6/   
�������$��0 0 0 20q�6N   5=      5>      �� 5G      .+�5H      �� -	   5        $��BtnCalculate��5H      
�������$��Calculate BMI��6D   $��0 20 0 0q�6\   6n   �� 5I      -
   5        $��BtnReset��5I      
�������$��Reset��6@   $��0 20 0 0q�6P   6b   �� 5J      -   5        $��BtnExit��5J      
�������$��Exit application��6?   $��0 20 0 0q�6Z   6l   �� 5M      $��Result BMR:��6    $	��150��63   $��0 20 0 0q�6?    �� TextAlignment$ Center=�6Q   �� 5N      -   5        $��	txtResult��5N      $	��150��6+   
�������$��0 0 0 20q�6J   5O      5U      �� 5X   
   $��1��6   $��20q�6%   .+�5[      �� $��1q�6   
���   �.��5\      �� $ 
Horizontal=�6   .+�5]      �� $	��100��6   $��60��6(   $����C:\Users\apmel\OneDrive\IDEs\Visual-Studio-Files\C#\CentennialProgramming02\Assignment04-AdrianoMelquiades\Assignment04-Adriano_Melquiades\img\startImage.jpg��64   �� 5^      $��BMR Results��6   $��38(�62   5_      5`      �� 5c      $.��(Please, select filename to open and edit��6   $��Center=�6G   &   System.Windows.Controls.DataGrid  5d      -   5        $��txtFilesToOpen��5d         
IsReadOnly$
 true��6-   6t   �� 5h      $	��Age��6   $��Center=�6"   �� 5i      -   5        $��	ResultAge��5i       �� TextWrapping$
 Wrap=�6'   $	��120��6;   �� 5j      $��Height��6   $��Center=�6%   �� 5k      -   5        $��ResultHeight��5k      $
 Wrap=�6*   $	��120��6>   �� 5l      $��Weight��6   $��Center=�6%   �� 5m      -   5        $��ResultWeight��5m      $
 Wrap=�6*   $	��120��6>   �� 5r      -   5        $��	btnUpdate��5r      
�������$��0 20 0 0q�69   $��Update��6K   6\   �� 5t      -   5        $��	btnDelete��5t      
�������$��0 20 0 0q�69   $��Delete��6K   6\   �� 5y      $��Center=�6   .��61   0.---------------Query Buttons------------------6a   �� 5|      -   5        $��lessThan100��5|      
�������$��0 5 0 0q�6;   $��Less than 1500��6L   6e   �� 5}      -   5        $��MaxiBMI��5}      
�������$��0 20 0 0q�67   $��Max BMI��6I   6[   �� 5~      -   5        $��MinBMI��5~      
�������$��0 20 0 0q�66   $��Min BMI��6H   6Z   �� 5      -   5        $��average��5      
�������$��0 20 0 0q�67   $��Average��6I   6[   5�      5�      5�      