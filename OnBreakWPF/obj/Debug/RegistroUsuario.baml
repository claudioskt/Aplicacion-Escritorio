   M S B A M L   `   `   `  ����E  AOnBreakWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:OnBreakWPF
OnBreakWPF  5   	        OnBreakWPF.RegistroUsuario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:OnBreakWPF     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Registro Cliente��5	   	   $	��450��6"   $	��800��6/    � 
ResizeMode$ NoResize=�6;    � Icon$ Imagenes/Untitled-2.ico��6Q    � WindowStartupLocation$ CenterScreen=�6p   .��5
      �  � RowDefinitions 5   
   �� 5      .+�5   
   � -   5         �Name$ 	gridBlack��5      $y�Hidden=�6#   
���   �$
��Left=�6J   $	��420��6e   $	��Top=�6r   $	��794��6�   $��
0,0,-0.4,0q�6�   � 5   
   $
��Left=�6   $��81��6+   $��0,339,-0.4,0q�67   $	��Top=�6M   $	��794��6e   ���	#FF00C3FF6q   � 5   
   -   5        $ gridDown��5      $y�Hidden=�6!   $
��Left=�65   $��81��6P   $��0,339,-0.4,0q�6\   $	��Top=�6r   $	��794��6�   ���	#FF000ACD6�   �� 5   
   $	��RUT��6   $
��Left=�6   $��132.2,108.855,0,0q�69   $	��Top=�6T   $��24.08��6l   $��30.455��6{   
�������6�   �� 5   
   -   5         ��Name$	 lb2��5      $	��RUT��6   $
��Left=�6+   $��132.2,108.855,0,0q�6F   $	��Top=�6a   $��24.08��6y   $��30.455��6�   �� 5   
   $��RAZON SOCIAL��6   $
��Left=�6(   $��411.241,107,0,0q�6C   $	��Top=�6\   $��24.08��6t   $	��101��6�   
�������6�   �� 5   
   -   5        $	 lb7��5      $��RAZON SOCIAL��6   $
��Left=�64   $��411.241,107,0,0q�6O   $	��Top=�6h   $��24.08��6�   $��101.192��6�   �� 5   
   $��NOMBRE��6   $
��Left=�6!   $��132.2,156.162,0,0q�6<   $	��Top=�6W   $��24.08��6o   $��64.362��6~   
�������6�   �� 5   
   -   5        $	 lb3��5      $��NOMBRE��6   $
��Left=�6.   $��132.2,156.162,0,0q�6I   $	��Top=�6d   $��24.08��6|   $��64.362��6�   �� 5   
   $��EMAIL��6   $
��Left=�6    $��411.241,151.524,0,0q�6;   $	��Top=�6X   $��24.08��6p   $��55.637��6   
�������6�   �� 5   
   -   5        $	 lb8��5      $��EMAIL��6   $
��Left=�6-   $��411.241,151.524,0,0q�6H   $	��Top=�6e   $��24.08��6}   $��55.637��6�   �� 5   
   $��	DIRECCION��6   $
��Left=�6$   $��132.2,203.469,0,0q�6?   $	��Top=�6Z   $��24.08��6r   $��80.62��6�   
�������6�   �� 5   
   -   5        $	 lb4��5      $��	DIRECCION��6   $
��Left=�61   $��132.2,203.469,0,0q�6L   $	��Top=�6g   $��24.08��6   $��80.62��6�   �� 5   
   $��TELEFONO��6   $
��Left=�6#   $��132.2,246.138,0,0q�6>   $	��Top=�6Y   $��24.081��6q   $��80.62��6�   
�������6�   �� 5   
   -   5        $	 lb5��5      $��TELEFONO��6   $
��Left=�60   $��132.2,246.138,0,0q�6K   $	��Top=�6f   $��24.081��6~   $��80.62��6�   �� 5   
   $��ACTIVIDAD EMPRESA��6   $
��Left=�6-   $��132.2,287.88,0,0q�6H   $	��Top=�6b   $��24.08��6z   $��128.514��6�   
�������6�   �� 5   
   -	   5        $	 lb6��5      $��ACTIVIDAD EMPRESA��6   $
��Left=�69   $��132,288,0,0q�6T   $	��Top=�6i   $��24��6�   $	��129��6�   �� 5    
   $��TIPO EMPRESA��6   $
��Left=�6'   $��423.241,287.88,0,0q�6B   $	��Top=�6^   $��24.08��6v   $��95.534��6�   
�������6�   �� 5!   
   -
   5        $	 lb9��5!      $��TIPO EMPRESA��6   $
��Left=�64   $��423.241,287.88,0,0q�6O   $	��Top=�6k   $��24.08��6�   $��95.534��6�   �� 5#   
   -   5         ��Name$ btnGuardar_Copy1��5#      $
��Left=�6+   $	��Top=�6F   $	��120��6^   $��32��6j   
�������$��518,367,0,0q�6�   ���	#FF11E3E7.��5$      ��  �� Orientation$ 
Horizontal=�6   .+�5%      �� $��Imagenes/icoSaved.ico��6   $��19��67   $��24��6B   �� 5&      $��GUARDAR��6   $��16��6+   $��56��67   $��RightToLeft=�6B   ���	#DD000000$��11(�6u   5'      5(      �� 5*   
   -   5        $ btnEliminar��5*      $
��Left=�6&   $��197,367,0,0q�6A   $	��Top=�6V   $	��120��6n   $��32��6z   
����������	#FF11E3E7.��5+      �� $ 
Horizontal=�6   $��98��62   .+�5,      �� $��Imagenes/icoDele.ico��6   $��19��66   �� 5-      $��ELIMINAR��6   $��16��6,   ���	#DD000000$��57��6O   $��11(�6Z   $��RightToLeft=�6h   5.      5/      �� 50   
   $��REGISTRO CLIENTE��6   $��436,0,0,358.8q�6+   $��Dubai Medium)�6B   $��24(�6\   $
��Left=�6j   $	��212��6�   $��38��6�   $��Bottom=�6�   
�������6�   �� 51   
   -   5        $	 lb1��51      $��REGISTRO CLIENTE��6   $��436,0,0,358.8q�68   $��Dubai Medium)�6O   $��24(�6i   $
��Left=�6w   $	��212��6�   $��38��6�   $��Bottom=�6�   �� 52   
   $��Imagenes/logo1.png��6   $��136.4,24,560.2,323.8q�6,   �� 53   
   -   5        $ btnConsultar��53      $
��Left=�6'   $��357,367,0,0q�6B   $	��Top=�6W   $	��120��6o   $��32��6{   
�������$
��16,4q�6�   	 � UseLayoutRounding	 .  ���	#FF11E3E7.��54      �� $ 
Horizontal=�6   $��97��62   .+�55      �� $��Imagenes/icoSearch.ico��6   $��19��68   �� 56      $��	CONSULTAR��6   $��16��6-   $��67��69   ���	#DD000000$��11(�6[   $��RightToLeft=�6i   57      58      �� 59   
   -   5        $ btnBack��59      $y�Visible=�6"   $��2,6,675.6,376q�67   
 J� OpacityMask

 �   �$��0q�6�   $��-8,1,1,1q�6�   $
��Auto��6�   ��6N   Z� ��6�   Z� .��5:      �� $ 
Horizontal=�6   $��90��62   $��38��6=   .+�5;      �� $��Imagenes/icoback.ico��6   $��25��66   $��30��6B    J� RenderTransformOrigin$ 
0.59,0.503&�6M   $	��Top=�6p   $
��Left=�6�   �� 5<      $��VOLVER��6   $��55��6*   $��Center=�65   $��Center=�6P   $��25��6m   ���	#DDFFFFFF$��0,0,0,7q�6�   5=      5>      �� 5?   
   -   5        $ btnBack1��5?      $��2,6,675.6,376q�6#   

 �   �$��0q�6�   $��-8,1,1,1q�6�   $
��Auto��6�   ��6:   Z� ��6z   Z� .��5@      �� $ 
Horizontal=�6   $��90��62   $��38��6=   .+�5A      �� $��Imagenes/icoback.ico��6   $��25��66   $��30��6B   $ 
0.59,0.503&�6M   $	��Top=�6p   $
��Left=�6�   �� 5B      $��VOLVER��6   $��55��6*   $��Center=�65   $��Center=�6P   $��25��6m   ���	#DD000000$��0,0,0,7q�6�   5C      5D      �� 5E   
   -   5         ��Name$ txtRUT��5E      $��25��6"   $��264.753,107,0,0q�6.    �� TextWrapping$
 Wrap=�6G   $	��Top=�6[   $
��Left=�6s   $	��116��6�   $��1q�6�    �� 
CaretBrush �	#FF11E3E7
����������	#89867E7E6�   �� 5F   
   -   5        $ 	txtNombre��5F      $
��Left=�6%   $��25��6@   $��265.714,156.162,0,0q�6L   $
 Wrap=�6i   $	��Top=�6}   $	��116��6�   $��1q�6�    �	#FF11E3E7
����������	#89867E7E6�   �� 5G   
   -   5        $ txtDireccion��5G      $
��Left=�6(   $��25��6C   $��265.714,201.614,0,0q�6O   $
 Wrap=�6l   $	��Top=�6�   $	��371��6�    �	#FF11E3E7$��1q�6�   ���	#89867E7E
�������6�   �� 5H   
   -   5        $ txtTelefono��5H      $
��Left=�6'   $��25��6B   $��265.714,246.138,0,0q�6N   $
 Wrap=�6k   $	��Top=�6   $	��116��6�    �	#FF11E3E7$��1q�6�   
����������	#89867E7E6�   �� 5I   
   -   5        $ txtRazon��5I      $
��Left=�6$   $��25��6?   $��519,110,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $	��116��6�   $��1q�6�   
����������	#89867E7E6�   �� 5J   
   -   5        $ txtEmail��5J      $
��Left=�6$   $��25��6?   $��519.294,156.162,0,0q�6K   $
 Wrap=�6h   $	��Top=�6|   $	��116��6�   $��1q�6�    �	#FF11E3E7
����������	#FFB4B0B06�   �� 5K   
   -   5         ��Name$ cbxActividad��5K      $
��Left=�6)   $��266,288,0,0q�6D   $	��Top=�6Y   $	��115��6q   ���	#89867E7E$��25��6�   
�������6�   �� 5L   
   -   5        $ cbxTipoE��5L      $
��Left=�6%   $��533,288,0,0q�6@   $	��Top=�6U   $	��115��6m   ���	#89867E7E$��25��6�   
�������6�   �� 5M   
   -   5        $ btnContraste1��5M      $y�Visible=�6(   $��10,351,675.6,0q�6=   $
��Auto��6�   ��6q   Z� ��6�   Z� .��5N      �� $ Vertical=�6   $��59��60   $��75��6<   .+�5O      �� $��Imagenes/icoBrillo.ico��6   $��36��68   $��37��6D   $ 0.497,-0.767&�6O   �� 5P      $��	CONTRASTE��6   $��9(�6-   
�������$��10,0,10.2,0q�6N   $��13��6c   5Q      5R      �� 5S   
   -   5        $ btnContraste��5S      $��10,351,675.6,0q�6'   $
��Auto��6�   ��6Z   Z� ��6p   Z� .��5T      �� $ Vertical=�6   $��59��60   $��75��6<   .+�5U      �� $��Imagenes/icoBrillo.ico��6   $��36��68   $ 0.497,-0.767&�6D   $��10,0,10.2,0q�6i   �� 5V      $��	CONTRASTE��6   $��9(�6-   
���   �$��10,0,10.2,0q�6M   $��13��6b   5W      5X      5Y      5Z      