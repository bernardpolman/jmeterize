   M S B A M L   `   `   `  ����G  CJMeterizeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:JMeteorApp
JMeteorApp  5   	       JMeteorApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:JMeteorApp     5   	   #��� ��5   	     � Title$  JMeteor��5   	   $	��471��6   $	��450��6&   .��5	      � $	��442��6   $	��Top=�6   $��0,0,0,-2q�60   .+�5
   
   �� -   5        $��	btnBrowse��5
      $��Browse��6"   $
��Left=�6K   $��
327,25,0,0q�6f   $	��Top=�6z   $��75��6�   $��24��6�   �� 5   
   -   5        $��labelScriptName��5      $��No JMeter script chosen��6'   $
��Left=�6I   $��	10,60,0,0q�6d   $	��Top=�6w   $	��422��6�   $��Lucida Sans Typewriter)�6�   $��16(�6�   �� 5   
   -   5        $��checkboxGenerateCSV��5      $��Generate CSV file��6.   $
��Left=�6J   $��
20,127,0,0q�6e   $	��Top=�6y   �� 5   
   -   5        $��checkboxGenerateHTML��5      $��Generate HTML report��6/   $
��Left=�6N   $��
20,147,0,0q�6i   $	��Top=�6}   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � {� �� Value . 6A   �� 5       �@d�	IsChecked$ FalseY�62   6B    �� Triggers 5      �� 5       �� Binding 6&   �� *	IsChecked+ �� ElementName$ checkboxGenerateCSV�� �� Value	 False6d   .a�5      ��  �@d�	IsChecked$ FalseY�6:   �� 5       � {� .  6:   5      5      5      �� 5   
   -   5        $��btnRun��5      $��Run test��6   $
��Left=�5      $��
10,189,0,0q�6,   $	��Top=�6@   $��75��6X   {�5   G   �� *FileOk+5   X   �� 5   
   -   5        $��txtScriptPath��5       �� 
IsReadOnly . $
��Left=�69   $��23��6T   $��	10,26,0,0q�6`   	 �� TextWrapping$	 NoWrap=�6s   $��Select a JMeter script...��6�   $	��Top=�6�   $	��312��6�   6�   �� 5   
   -   5        $��txtLog��5      $
��Left=�6"   $��10,225,10,10q�6=   $
��Wrap=�6S   $	��Top=�6g   $	��195��6   $	��422��6�   
�������$��Lucida Sans Typewriter)�6�   
 �� Padding$
 10q�6�   �� 5   
   $��Export results��6   $
��Left=�6+   $��73��6F   $��
10,102,0,0q�6R   $	��Top=�6f   $	��412��6~   5       5!      