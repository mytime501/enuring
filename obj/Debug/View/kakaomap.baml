   M S B A M L   `   `   `  ����D  @에누링, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:에누링.View에누링.View  5   	   9!clr-namespace:에누링.ViewModel에누링.ViewModel  5   	   I)clr-namespace:에누링.ViewModel.Command에누링.ViewModel.Command  5	   	       에누링.View.kakaomap   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5   	   (localclr-namespace:에누링.View  5   	   +avm!clr-namespace:에누링.ViewModel  5   	   6select)clr-namespace:에누링.ViewModel.Command  5	   	     � Title$  kakaomap��5   	   $	��450��6   $	��800��6'    � DataContext 5      !   에누링.ViewModel.Kakaovm  5   
    � 	Resources 5      .  (에누링.ViewModel.Command.Selectbutton   st��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��9* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� $��Right=�5      $��Center=�5       
검색어:5!      �� 5#   
   -   5        $��
tbox_query��5$      $��1��5%      $��5,0,5,0q�5&      $��Center=�5'      
���������5)      �� *	InputText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5+   
   -   5        $��
btn_search��5,      $��2��5-      $��Center=�5.      $��검색��50       �� 	IsDefault . ��5/      �� *SearchCommand+51      �� 53   
   -   5        $��lbox_locale��54      $��1��55      
����� ���57      �� *	MyLocales+ �� SelectedItem 58      �� *SelectedMyLocale+$ TwoWay=��� 5:   
   $��1��5;      $��	0,335,0,0q�5<      $��선택완료��5=      ��5>      �� 	 �� Source#	 [  ��5?      �� 
 �� ElementName$
 lbox_locale�� �� Path$ SelectedItem�(  "System.Windows.Controls.WebBrowser  5B   
   -   5        $��wb��5C      $�� 1��5D      $��1��5E      $��3��5F         Source$) #http://127.0.0.1:8886/kakaomap.html?�5G      *  $Microsoft.Xaml.Behaviors.Interaction   	Behaviors 5H      ,   &에누링.ViewModel.WebBrowserBehavior  5I         SelectedMyLocale 6)   �� *SelectedMyLocale+5K      5L      5M      