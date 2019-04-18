# JMeterize
A simple WPF app for executing JMeter scripts in non-GUI mode, hassle free!

JMeterize executes JMeter test scripts in fast non-GUI mode but makes it easier to choose scripts and optional parameters without writing long and tedious command lines.

### **How does it work?**
1. Choose a JMeter script through the file browser dialog
2. Click "Run test"
3. Done! JMeter will run the test in non-GUI mode

You can also choose optional parameters to generate a .CSV file with test results and a HTML report. If you choose any of these options, JMeter will generate a folder containing your test results in the same location where your test script is located.

### **Prerequisites**

The only thing needed for JMeterize to work properly is having the JMeter application located on your machine. Upon first running JMeterize you will be prompted to locate the JMeter **'bin'** folder.
This only needs to be done first time you run JMeterize!

### **To-do list**

- [ ] Add usage instructions inside application
- [ ] Add a menu with additional options:
  - Changing directory of JMeter 'bin' folder
  - Choose a different script
  - Convert existing .CSV file to HTML report
  - Exit application
- [ ] Code cleanup

#### **NOTE**

Since I create and run JMeter load & test scenarios on commercial applications to analyze their performance, I created this this app to speed up script execution without the hassle of writing command lines and long paths to folders.
This is my first WPF app with specfic functionality so any feedback on UI, functionality and code fixing is appreciated!
