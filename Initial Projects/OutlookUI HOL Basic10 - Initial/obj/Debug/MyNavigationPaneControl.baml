   M S B A M L   `   `   `  ����H  DOutlookUI_HOL, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:OutlookUI_HOLOutlookUI_HOL  5      +    %OutlookUI_HOL.MyNavigationPaneControl   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6x,http://schemas.microsoft.com/winfx/2006/xaml   5      1OutlookUI_HOLclr-namespace:OutlookUI_HOL   5      -   5          >�Name$  myNavigationPaneControl��5      $	��500��5      $
��Auto��6   .��5	      � -   5         �Name$ myNavigationGrid��5	   	   $
��Left=�6#   $	��Top=�6>   $	��500��6V    � ColumnDefinitions 5
      �� 5      $��0.402* �6   �� 5      $��0.598* �6   .+�5      ��  J� Opacity$	 0.5Q�6    J� OpacityMask �	#FF000000$��4��6F   $��	4,4,-4,-4q�6Z   $��1��6m   ��66   Z� ��5      �� 5   
    �� EndPoint$ 1.001,0.535&�6    �� 
StartPoint$ 0.982,0.535&�65   .��5      �  � Color$ 	#FF484848��6    � Offset$ 0.279Q�6+   � 5      $ 	#FFFFFFFF��6   $ 1Q�6+   5      5      �� 5      -   5        	 ��Name$	 myNavigationBorder1��5         MyDarkBlueSolidBrush#���   6*   $��0.5,0.5,0.5,0.5q�6_   $��1��6�   ._�5      �� -   5        $	 myNavigationBorder2��5   �     MyBrightBlueSolidBrush2#���  6   $��5,5,5,5q�6G   $
��Auto=�6a   $
��Auto=�6�   ._�5   
   �� -   5        $	 myNavigationBorder3��5   �   #���   6   $��0.5,0.5,0.5,0.5q�6F   ���	#FFFFFFFF$
��Auto=�6   ._�5      � 
 � RowDefinitions
 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5      -   'OutlookUI_HOL.MyFoldersExpandersControl  -   'OutlookUI_HOL.MyFoldersExpandersControl   PreviewMouseLeftButtonUp$) #myTreeView_PreviewMouseLeftButtonUp��6�   $��0��66   $
��Auto��6C   $
��Auto��6P   $��Stretch=�6^   $��Stretch=�6|   6�   �� 5      $��1��6   $��Stretch=�6'   $
��Auto��6E   $
��Auto��6R   $��Right=�6`   $��0,0,2,2q�6�   5       5!      5"   	   5#      �� 5$      -   5         ��Name$ myNavigationSplitter��5$   �   $��Right=�6   $��Stretch=�6/   $��5��6K   #���  6U   $��0��6�   #���   6�   $��0,0.5,0.5,0.5q�6  ��6�   Z� 6  5%      5&      