   M S B A M L   `   `   `  ����C  ?MahoaRSA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MahoaRSAMahoaRSA  5   	       MahoaRSA.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MahoaRSA     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Nhập dữ liệu vào:��6   $
��Left=�6,   $��31��6G   $��	43,41,0,0q�6S   $	��Top=�6f   $	��118��6~   �� 5   
   $��Chuỗi mã hóa RSA:��6   $
��Left=�6,   $��31��6G   $��
43,138,0,0q�6S   $	��Top=�6g   $	��118��6   �� 5   
   $��Chuỗi giải mã RSA:��6   $
��Left=�6-   $��32��6H   $��
43,338,0,0q�6T   $	��Top=�6h   $	��118��6�   �� 5   
   $��Public key:��6   $
��Left=�6&   $��32��6A   $��466,136,0,0q�6M   $	��Top=�6b   $	��118��6z   �� 5   
   $��Private Key:��6   $
��Left=�6'   $��31��6B   $��466,338,0,0q�6N   $	��Top=�6c   $	��118��6{   �� 5   
   -   5         ��Name$ 
btnDecrypt��5      $��Giải mã RSA��6%   $
��Left=�6;   $��31��6V   $��227,338,0,0q�6b   $	��Top=�6w   $	��105��6�   6�   �� 5   
   -   5        $ btnLoadPublic��5      $$��Tạo khóa public và private��6(   $
��Left=�6M   $��32��6h   $��589,137,0,0q�6t   $	��Top=�6�   $	��157��6�   6�   �� 5   
   -   5         ��Name$ richPlaintext��5      $
��Left=�6)   $��61��6D   $��	43,72,0,0q�6P   $�� ��6c    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��306��6�   �� 5   
   -   5        $ 
richCipher��5      $
��Left=�6&   $	��156��6A   $��
43,174,0,0q�6N   $�� ��6b   $
 Wrap=�6j   $	��Top=�6~   $	��306��6�   �� 5   
   -   5        $ richOutDecrypted��5      $
��Left=�6,   $	��170��6G   $��
43,385,0,0q�6T   $�� ��6h   $
 Wrap=�6p   $	��Top=�6�   $	��306��6�   �� 5   
   -   5        $ richTextPublic��5      $
��Left=�6*   $	��156��6E   $��466,174,0,0q�6R   $�� ��6g   $
 Wrap=�6o   $	��Top=�6�   $	��306��6�   �� 5   
   -   5        $ richTextPrivate��5      $
��Left=�6+   $	��170��6F   $��466,385,0,0q�6S   $�� ��6h   $
 Wrap=�6p   $	��Top=�6�   $	��306��6�   �� 5   
   -	   5        $ 
btnEncrypt��5      $��Mã hóa RSA��6%   $
��Left=�6:   $��30��6U   $��227,138,0,0q�6a   $	��Top=�6v   $	��105��6�   6�   5      5      