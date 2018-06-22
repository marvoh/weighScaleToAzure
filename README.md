
# weighScaleToAzure
This is a short example showing how you can connect a weighing scale to the computer and read the data, combine it with more information and finally dump it into an MS SQL Database on Azure.

This is a simple WinForm app built on C#. Run the soltion and pushlish to see in action

<h3>Setting Up</h3>

Once you have installed the application, head to <b>File > Config</b> to set up the application. You will be required to prive the following:

<ul>
  <li>Provide terminal name to identify source of data</li>
  <li>Enter port number to which the weighing scale is connected to</li>
  <li>Select baud rate at which the weighing scale is communicating at</li>
  <li>Provide SQL server connection strings retrieved from Azure SQL Server <em>You can adapt code to connect to any database server</em></li>
</ul>

Once you have saved the settings, you will be able to read data perform the rest of the actions.

Please feel free to ping me in case of any question.
