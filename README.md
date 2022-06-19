# SignatureEditor (V1 - 2012 / V2 - 2014) 

I wrote this application because the marketing department required me to regularly update over 100 email signatures across 5 physical sites.
<br>
It was time consuming and I couldn't focus on upgrading the Server infrastructure. <br>
So I took a couple of days away from normal work tasks and focused on building an application which did the work for me as and when needed.
<br><br>
The application gets user details via a Windows Form app and it edits an HTML template file with the inputted data. <br><br>
It then copies to a centralised location to be backed up etc.
<br><br>
Here are the original instructions I wrote...
<br><br>
SignatureEditor 2.0
O.Armstrong � 2014

The SignatureEditor application has adjustable settings in its own config file "SignatureEditor .exe.config".

You must first configure the settings in the config file to suit the needs of your environment.
The default settings are to run everything from the same folder that the application is in.

Config settings:

ServerSigLocation = Location where the completed signature will be saved, e.g. a shared drive on a server.
NewSigLocation = This is the location of the htm signature template file.
NewSigImages = This is the location of the images to be copied to the users local profile on their PC.
YearOfSignature = This is used when naming the signature, so that a record of old signatures can be kept. (enter the current year).
PhoneFromTempl = This is the phone number that has been used in the htm template file (NewSigLocation)
MobileFromTempl = This is the mobile phone number that has been used in the htm template file 
FaxFromTempl = This is the fax number that has been used in the htm template file 
EmailFromTempl = This is the email address that has been used in the htm template file 
FirstnameLastname = This is the firstname and lastname place holder that has been used in the htm template file 
JobDescription = This is the place holder for the job description field that has been used in the htm template file 
JobDescFile = This is the txt file that contains a list of employees and their job descriptions. The name and job description should be seperated by a comma and a space e.g. John Doe, Manager




FIRST RUN:
On the first run the application will prompt with user account control if enabled, it will then look for the Job Description File 'JobDescFile', and store it as a searchable list. (It will not error if the file is not found).
You will notice the 'Go' button is not enabled, this is because it requires a first and last name to be entered first.

Once you type in a first name and either click or tab to the next field, the app will automatically captialise the first letter, this is the same for the lastname and jobtitle fields.

Once you click or tab out of the lastname field, the application will search the list (JobDescFile) for the employee name and get their job description and auto-populate it into the jobtitle field. If a match is not found the Jobtitle textbox will be enabled to allow a job description to be manually typed in.

If you click 'Go' after filling in the 3 top fields it will prompt you to enter the remaining details except for a fax number, as this is NOT required.

The Phone, mobile and fax fields will ONLY accept numbers not letters, and they have been set to accept a maximum of 8 digits in length, and any less than 8 and it will warn that it requires a minimum of 8.

After you enter a phone mobile or fax number and tab or click to the next field, the app will automatically format the number.

If you do not enter a fax number it will be left out of the final signature.

The email address will also be checked to make sure it meets a standard email address format.

When you click 'Go' after filling out all fields, the app replaces the placeholder fields in the template file, with the values entered into the app. It copies the edited template htm file to the server location folder, and then copies the new htm file to the Outlook signatures folder in the local user profile, it then copies the images from the imagelocation set in the config file to the Outlook signatures folder in the local user profile.

One the items have been copied to the server and local profile, the app creates a file called 'Sig.se' in the Outlook signatures folder in the local user profile. This file is used by the app after the first run.



AFTER FIRST RUN:
If you run the app after it has successfully been run and has created a signature, upon opening it will first check the local profile for the 'Sig.se' file. If that file exists the app will close without being shown. However if the app has been passed a command line argument of '/del' the application will delete the 'Sig.se' file and restart itself, to allow you to change or create a new signature.



COMMAND LINE TO DELETE Sig.se FILE:

From a command prompt window run the SignatureEditor app with the following command:

SignatureEditor.exe /del


