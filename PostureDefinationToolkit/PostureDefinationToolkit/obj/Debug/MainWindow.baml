   M S B A M L   `   `   `  ����S  OPostureDefinationToolkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PostureDefinationToolkitPostureDefinationToolkit  5   	   )    #PostureDefinationToolkit.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:PostureDefinationToolkit     5   	     � Title$  
MainWindow��5   	   $��674.415��6   $	��510��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ Layout��5
      ���	#FFC5EFCE$��0,5,2,1q�68   .+�5      �� -   5         ��Name$ HipCenter_Spine��5      
���   �$��2��5      	 �� X1 5      �� *
HipCenterX+	 �� Y1 5      �� *
HipCenterY+	 �� X2 5      �� *SpineX+	 �� Y2 5      �� *SpineY+5      �� 5      -   5        $ Spine_ShoulderCenter��5      
���   �$��2��5       5      �� *X2+ �� ElementName$ HipCenter_Spine�� �� Mode$ TwoWay=� 5      �� *Y2+$ HipCenter_Spine��$ TwoWay=� 5      �� *ShoulderCenterX+ 5      �� *ShoulderCenterY+5      �� 5      -   5        $ ShoulderCenter_Head��5      
���   �$��2��5       5      �� *X2+$ Spine_ShoulderCenter��$ TwoWay=� 5      �� *Y2+$ Spine_ShoulderCenter��$ TwoWay=� 5      �� *HeadX+ 5      �� *HeadY+5      �� 5      -   5        $! ShoulderCenter_ShoulderLeft��5      
���   �$��2��5"       5      �� *X2+$ Spine_ShoulderCenter��$ TwoWay=� 5      �� *Y2+$ Spine_ShoulderCenter��$ TwoWay=� 5       �� *ShoulderLeftX+ 5!      �� *ShoulderLeftY+5"      �� 5#      -   5        $" ShoulderCenter_ShoulderRight��5#      
���   �$��2��5(       5$      �� *X2+$ Spine_ShoulderCenter��$ TwoWay=� 5%      �� *Y2+$ Spine_ShoulderCenter��$ TwoWay=� 5&      �� *ShoulderRightX+ 5'      �� *ShoulderRightY+5(      �� 5)      -   5        $ ShoulderLeft_ElbowLeft��5)      
���   �$��2��5.       5*      �� *X2+$! ShoulderCenter_ShoulderLeft��$ TwoWay=� 5+      �� *Y2+$! ShoulderCenter_ShoulderLeft��$ TwoWay=� 5,      �� *
ElbowLeftX+ 5-      �� *
ElbowLeftY+5.      �� 5/      -   5        $ ShoulderRight_ElbowRight��5/      
���   �$��2��54       50      �� *X2+$" ShoulderCenter_ShoulderRight��$ TwoWay=� 51      �� *Y2+$" ShoulderCenter_ShoulderRight��$ TwoWay=� 52      �� *ElbowRightX+ 53      �� *ElbowRightY+54      �� 55      -	   5        $ ElbowLeft_WristLeft��55      
���   �$��2��5:       56      �� *X2+$ ShoulderLeft_ElbowLeft��$ TwoWay=� 57      �� *Y2+$ ShoulderLeft_ElbowLeft��$ TwoWay=� 58      �� *
WristLeftX+ 59      �� *
WristLeftY+5:      �� 5;      -
   5        $ ElbowRight_WristRight��5;      
���   �$��2��5@       5<      �� *X2+$ ShoulderRight_ElbowRight��$ TwoWay=� 5=      �� *Y2+$ ShoulderRight_ElbowRight��$ TwoWay=� 5>      �� *WristRightX+ 5?      �� *WristRightY+5@      �� 5B      -   5        $ HipCenter_HipLeft��5B      
���   �$��2��5G       5C      �� *
HipCenterX+ 5D      �� *
HipCenterY+ 5E      �� *
HipLeftX+ 5F      �� *
HipLeftY+5G      �� 5H      -   5        $ HipCenter_HipRight��5H      
���   �$��2��5M       5I      �� *
HipCenterX+ 5J      �� *
HipCenterY+ 5K      �� *	HipRightX+ 5L      �� *	HipRightY+5M      �� 5N      -   5        $ HipLeft_KneeLeft��5N      
���   �$��2��5S       5O      �� *X2+$ HipCenter_HipLeft��$ TwoWay=� 5P      �� *Y2+$ HipCenter_HipLeft��$ TwoWay=� 5Q      �� *	KneeLeftX+ 5R      �� *	KneeLeftY+5S      �� 5T      -   5        $ HipRight_KneeRight��5T      
���   �$��2��5Y       5U      �� *X2+$ HipCenter_HipRight��$ TwoWay=� 5V      �� *Y2+$ HipCenter_HipRight��$ TwoWay=� 5W      �� *
KneeRightX+ 5X      �� *
KneeRightY+5Y      �� 5Z      -   5        $ KneeLeft_AngleLeft��5Z      
���   �$��2��5_       5[      �� *X2+$ HipLeft_KneeLeft��$ TwoWay=� 5\      �� *Y2+$ HipLeft_KneeLeft��$ TwoWay=� 5]      �� *
AngleLeftX+ 5^      �� *
AngleLeftY+5_      �� 5`      -   5        $ KneeRight_AngleRight��5`      
���   �$��2��5e       5a      �� *X2+$ HipRight_KneeRight��$ TwoWay=� 5b      �� *Y2+$ HipRight_KneeRight��$ TwoWay=� 5c      �� *AngleRightX+ 5d      �� *AngleRightY+5e      �� 5f      -   5        $ AngleLeft_FootLeft��5f      
���   �$��2��5k       5g      �� *X2+$ KneeLeft_AngleLeft��$ TwoWay=� 5h      �� *Y2+$ KneeLeft_AngleLeft��$ TwoWay=� 5i      �� *	FootLeftX+ 5j      �� *	FootLeftY+5k      �� 5l      -   5        $ AngleRight_FootRight��5l      
���   �$��2��5q       5m      �� *X2+$ KneeRight_AngleRight��$ TwoWay=� 5n      �� *Y2+$ KneeRight_AngleRight��$ TwoWay=� 5o      �� *
FootRightX+ 5p      �� *
FootRightY+5q      A� 5u      -   5        	 A�Name$
	 Head��5u      ���	#FFF4F4F5$��8��5x   #   
���   �$��8��6=   
 �� Left
 5v      �� *X2+$ ShoulderCenter_Head��$ TwoWay=�
 �� Top 5w      �� *Y2+$ ShoulderCenter_Head��$ TwoWay=�5x   =   A� 5y      -   5        $	 ShoulderCenter��5y      ���	#FFF4F4F5$��8��5|   #   
���   �$��8��6>   
 5z      �� *X2+$ Spine_ShoulderCenter��$ TwoWay=� 5{      �� *Y2+$ Spine_ShoulderCenter��$ TwoWay=�5|   >   A� 5}      -   5        $	 Spine��5}      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5~      �� *X2+$ HipCenter_Spine��$ TwoWay=� 5      �� *Y2+$ HipCenter_Spine��$ TwoWay=�5�   >   A� 5�      -   5        $	 	HipCenter��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *
HipCenterX+ 5�      �� *
HipCenterY+5�   >   A� 5�      -   5        $	 ShoulderLeft��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$! ShoulderCenter_ShoulderLeft��$ TwoWay=� 5�      �� *Y2+$! ShoulderCenter_ShoulderLeft��$ TwoWay=�5�   >   A� 5�      -   5        $	 	ElbowLeft��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ ShoulderLeft_ElbowLeft��$ TwoWay=� 5�      �� *Y2+$ ShoulderLeft_ElbowLeft��$ TwoWay=�5�   >   A� 5�      -   5        $	 	WristLeft��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ ElbowLeft_WristLeft��$ TwoWay=� 5�      �� *Y2+$ ElbowLeft_WristLeft��$ TwoWay=�5�   >   A� 5�      -   5        $	 KneeLeft��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ HipLeft_KneeLeft��$ TwoWay=� 5�      �� *Y2+$ HipLeft_KneeLeft��$ TwoWay=�5�   >   A� 5�      -   5        $	 	AngleLeft��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ KneeLeft_AngleLeft��$ TwoWay=� 5�      �� *Y2+$ KneeLeft_AngleLeft��$ TwoWay=�5�   >   A� 5�      -   5        $	 FootLeft��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ AngleLeft_FootLeft��$ TwoWay=� 5�      �� *Y2+$ AngleLeft_FootLeft��$ TwoWay=�5�   >   A� 5�      -   5        $	 ShoulderRight��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$" ShoulderCenter_ShoulderRight��$ TwoWay=� 5�      �� *Y2+$" ShoulderCenter_ShoulderRight��$ TwoWay=�5�   >   A� 5�      -   5        $	 
ElbowRight��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ ShoulderRight_ElbowRight��$ TwoWay=� 5�      �� *Y2+$ ShoulderRight_ElbowRight��$ TwoWay=�5�   >   A� 5�      -   5        $	 
WristRight��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ ElbowRight_WristRight��$ TwoWay=� 5�      �� *Y2+$ ElbowRight_WristRight��$ TwoWay=�5�   >   A� 5�      -    5        $	 	HandRight��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ WristRight_HandRight��$ TwoWay=� 5�      �� *Y2+$ WristRight_HandRight��$ TwoWay=�5�   >   A� 5�      -!   5        $	 HipRight��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ HipCenter_HipRight��$ TwoWay=� 5�      �� *Y2+$ HipCenter_HipRight��$ TwoWay=�5�   >   A� 5�      -"   5        $	 	KneeRight��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ HipRight_KneeRight��$ TwoWay=� 5�      �� *Y2+$ HipRight_KneeRight��$ TwoWay=�5�   >   A� 5�      -#   5        $	 
AngleRight��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ KneeRight_AngleRight��$ TwoWay=� 5�      �� *Y2+$ KneeRight_AngleRight��$ TwoWay=�5�   >   A� 5�      -$   5        $	 	FootRight��5�      ���	#FFF4F4F5$��8��5�   #   
���   �$��8��6>   
 5�      �� *X2+$ AngleRight_FootRight��$ TwoWay=� 5�      �� *Y2+$ AngleRight_FootRight��$ TwoWay=�5�   >   �� 5�      -%   5        $��Store��5�      $
 30��6%   $	 578��66   $��75��6G   6R   �� 5�      -&   5        $��Compare��5�      $	
 124��6'   $	 578��69   $��75��6J   6U   �� 5�      -'   5        $
��num1��5�      $��30��6#   $
 30��6/    �� TextWrapping$
 Wrap=�6@   $.��(0000000000000000000000000000000000000000��6T   $	 543��6�   $	��417��6�   �� 5�      -(   5        $
��num2��5�      $��27��6#   $
 30��6/   $
 Wrap=�6@   $.��(0000000000000000000000000000000000000000��6T   $	 511��6�   $	��417��6�   �� 5�      -)   5        $
��num3��5�      $��15��6%   $	
 247��61   $
��Wrap=�6C   $��	TextBlock��6W   $	 578��6h   $	��105��6y   5�      5�      5�      