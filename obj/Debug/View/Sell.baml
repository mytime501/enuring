   M S B A M L   `   `   `  ����D  @에누링, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:에누링.View에누링.View  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      9!clr-namespace:에누링.ViewModel에누링.ViewModel  5      I)clr-namespace:에누링.ViewModel.Command에누링.ViewModel.Command  5	          에누링.View.Page1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:에누링.View     5      9system&clr-namespace:System;assembly=mscorlib     5      0ts!clr-namespace:에누링.ViewModel     5      Bmybtncommand)clr-namespace:에누링.ViewModel.Command     5	        N� Title$  Page1��5       � 	Resources 5      2   ,에누링.ViewModel.Command.OpenImageCommand   btnc0  *에누링.ViewModel.Command.kakaomapbutton  kmbt��%:   &	        &	        5   
   6(     5   
   6&   5       � DataContext 5      (  "에누링.ViewModel.PageNavigateVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5!   
   �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      .+�5,   
   ��  �� CornerRadius$ 10��6   $��7��5-      $��8��5.      ��5/      �� 50      .��51      �  � Color$ #7be9f6��6#    � Offset$	 0.0Q�63   � 52      $ #f083da��6#   $ 1Q�63   53      55      � 57   
   $��1��6   $��3��58      $��3��59      
�������5;      �� 5=   
   $��판매희망 금액 :��6   $��3��5>      $��DemiBold"�5?      $��30(�5@      
�������
������ 5C      �� 5E   
   $��1��6   $��3��5F      .+�5G      ��  �� 	MaxLength$ 9��6   $��Right=�5I      
������ $��30(�5K      $��Light"�5L      
���������5H      �� *	MyPrice+  vm	 �� Source#	 [ .��5M   (   5N      �� 5O      $	��150��6   $��2��5P      
�������
 J� Opacity$
 1Q�5R      $��	170,0,0,0q�5S      5T      �� 5V   
   $	��원��6   $��2��5W      $��3��5X      $��30(�5Y      $��DemiBold"�5Z      
�������$
��Left=�5\      5]      �� 5_   
   $��경매종료일: ��6   $��4��5`      $��30(�5a      $��DemiBold"�5b      
�������
������ $��Right=�5e      5f      �� 5g   
   $��물품설명: ��6   $��5��5h      $��30(�5i      $��DemiBold"�5j      
�������
������ $��Right=�5m      5o      �� 5p   
   -   5         ��Name$ ProductExplain��5|      $
��Left=�5q      
������ $��25(�5t      $��Light"�5u      
�������$��1��5w      $��5��5x      $��2��5y       �� AcceptsReturn .  �� 
AcceptsTab .  �� TextWrapping$ WrapWithOverflow=�5{      ��5r      �� *
MyExplan+#	 [ .��5|   +   5}      �� 5~   
   $��제품명: ��6   $��6��5      $��30(�5�      $��DemiBold"�5�      
�������
������ $��Right=�5�      5�      �� 5�   
   $
��Left=�5�      
������ $��25(�5�      $��Light"�5�      
�������$��1��5�      $��6��5�      $��2��5�       .  . $ WrapWithOverflow=�5�      ��5�      �� *MyName+#	 [ .��5�      5�      �� 5�      $��품질��6   $��4��5�      $��4��5�      $��Bottom=�5�      $��Center=�5�      $��30(�5�      
�������5�      �� 5�   
   $��개봉여부��6   $��5��5�      $��4��5�      $��Bottom=�5�      $��Center=�5�      $��30(�5�      
�������5�      �� 5�   
   $��거래방법��6   $��6��5�      $��4��5�      $��Bottom=�5�      $��Center=�5�      $��30(�5�      
�������5�      �� 5�   
   $��4��6   $��5��5�      $��2��5�      .��5�      �� .+�5�      	� -   5        $	��상��5�      
 � Tag$ 1��6*   $��0,0,0,30q�62   $��25(�6E   6S   	� 5�      -   5        $	��중��5�      $ 2��6*   $��0,0,0,30q�63   $��25(�6E   6S   	� 5�      -   5        $	��하��5�      $ 3��6*   $��0,0,0,30q�63   $��25(�6E   6S   5�      5�      �� 5�   
   $��5��6   $��5��5�      $��2��5�      .��5�      �� .+�5�      	� -   5        $��개봉��5�      $ 1��6+   $��0,0,0,30q�63   $��25(�6F   6T   	� 5�      -   5        $��	미개봉��5�      $ 2��6,   $��0,0,0,30q�65   $��25(�6G   6U   5�      5�      �� 5�   
   $��6��6   $��5��5�      $��3��5�      .��5�      �� .+�5�      	� -   5        $��택배��5�      $ 1��6+   $��0,0,0,30q�63   $��25(�6F   6T   	� 5�      -   5        $��	직거래��5�      $ 2��6,   $��0,0,0,30q�65   $��25(�6G   6U   5�      5�      �� 5�   
   $��7��6   $��5��5�      $��2��5�      $��등록��5�      $��Ok��5�      ��5�      �� #	 [  �� Path$ PageNavigateCommand�5�      �� 5�   
   $��1��5�      $��4��5�      $��2��5�      .+�5�      (  "System.Windows.Controls.DatePicker  $	��300��6   $��50��6%   $	��Top=�5�      $��30(�5�      
������    SelectedDate 5�   1   �� *SelectedDateTime+5�      �� 5�      $��Center=�5�      $��Center=�5�      $��30(�5�      
���������5�      �� *SelectedDateTime+ �� StringFormat$&  선택된 날짜: {0:yyyy/MM/dd}��5�      5�      �� 5�   
   $��30(�5�      $
��Back��5�      $
��Back��5�      ���	#FF958FF9$	
 0.8Q�5�      
���������5�      �� #	 [ $ PageNavigateCommand�5�      �� 5�   
   $��30(�6   $��2��5�      $��이미지선택��5�      ��5�      �� #	 [  ��5�      ��  �� ElementName$ image���� 5�   
   -	   5         ��Name$ image��5�      $��3��5�      $��3��5      $
��Fill=�5     $��1��5     �� 5  
   $��0��6   $��4��5     $��4��5     $��3��5     ��5     �� #	 [ .��5	     �� $*��$/Resources/직거래장소선택.png��6   $
��Fill=�5
     5     5     5     