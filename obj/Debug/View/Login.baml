   M S B A M L   `   `   `  ����D  @에누링, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:에누링.View에누링.View  5          에누링.View.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:에누링.View     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5        N� Title$  Login��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��91* �6   �� 5      $	��34* �6   .+�5   
   � $��2��6    5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      5      �� 5"      $��Center=�6   .+�5#      �� $��Enuring��6   $��Light"�5$      $��	helvetica)�5%      $	��100(�5&      
�������$��Center=�5(      5)      �� 5+      $��1��6   .+�5,      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5-      .+�5.      �� $��
UserName: ��6   $��
-100,0,0,0q�5/      $��Light"�50      $��	helvetica)�51      $��20(�52      
�������53      �� 54      $��Light"�55      $��20(�57      $��Center=�58      
�������
������ $��0q�5;      $	��235��5<      $
��Left=�5=       J� Opacity$	 0.5Q�5>      $��25��5?      ��56      �� *MyID+ �� Path$ DBdata_insert�5?      .  (MahApps.Metro.IconPacks.PackIconMaterial  5A         Kind$ Account=�61   $��Center=�5B   1   $��Center=�5C   1   
�������5D   1   5E      �� 5G      $	��250��6   $��2��5H      
�������$	 0.5Q�5J      �� 5L      $ 
Horizontal=�6   $��0,20,0,0q�66   $��Center=�5M      .+�5N      �� $��
Password: ��6   $��
-100,0,0,0q�5O      $��Light"�5P      $��	helvetica)�5Q      $��20(�5R      
�������5S      �� 5T      $��	Helvetica)�6   $��Light"�5U      $��20(�5W      $��Center=�5X      
�������
������ $��0q�5[      $	��235��5\      $
��Left=�5]      $	 0.5Q�5^      $��25��5_      ��5V      �� *MyPw+   vm	 �� Source#	 [  5_        5a      $��Center=�5b      $��Center=�5c      
�������5d      5e      �� 5h      $	��250��6   $��2��5i      
�������$	 0.5Q�5k      �� 5l      $ 
Horizontal=�6   $��
-30,50,0,0q�66   $��Center=�5m      .+�5n      �� $	��200��5o      $	��100��5p      $��LOGIN��5q      $��Login��5u      $��	0,0,200,0q�5v      ��5s      �� #	 [  $ PageNavigateCommand�
 � 	Resources
 5z       �� 
TargetType �� Property �� Value��%_   '��       �� 5{      " ��6$   .�5|   "   ��  �@��CornerRadius$ 15��6A   5}      5~      5      �� 5�      $	��200��6   $	��100��5�      $��REGISTER��5�      $��Register��5�      ��5�      �� #	 [  $ PageNavigateCommand�
 5�      ��%_   '��       �� 5�      " ��6$   .�5�   "   ��  �@��CornerRadius$ 15��6A   5�      5�      5�      5�      5�      5�      5�      5�      