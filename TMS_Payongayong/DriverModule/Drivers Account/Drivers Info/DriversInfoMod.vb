Imports Telerik.WinControls.UI

Module DriversInfoMod

    'ALL OF THE COMMANDS REGARDING TO THE DRIVERS INFO ARE HERE

    'Set Info displayed on grid
    Public Sub displayNotRemoved()

        'change header text of the grid
        With Dashboard.gridDriver
            .Columns(2).HeaderText = "ID No."
            .Columns(3).HeaderText = "Last Name"
            .Columns(4).HeaderText = "First Name"
            .Columns(5).HeaderText = "Middle Name"
            .Columns(6).HeaderText = "License No."
            .Columns(7).HeaderText = "SSS No."
            .Columns(8).HeaderText = "Driver Status"
            .Columns(9).HeaderText = "Assigned Taxi"
            .Columns(10).HeaderText = "Age"
            .Columns(11).HeaderText = "Gender"
            .Columns(12).HeaderText = "Address"
            .Columns(13).HeaderText = "Civil Status"
            .Columns(14).HeaderText = "Mobile No."
            .Columns(15).HeaderText = "Religion"
            .Columns(16).HeaderText = "Contact Person"
            .Columns(17).HeaderText = "Contact Number"

            ''Hide columns
            .Columns(2).IsVisible = False
            '.Columns(9).IsVisible = False
            '.Columns(10).IsVisible = False
            '.Columns(11).IsVisible = False
            '.Columns(12).IsVisible = False
            '.Columns(13).IsVisible = False
            '.Columns(14).IsVisible = False
            '.Columns(15).IsVisible = False
            '.Columns(16).IsVisible = False
            .Columns(18).IsVisible = False
            .Columns(19).IsVisible = False

            'Fit all the columns
            '.Columns(0).BestFit()
            '.Columns(1).BestFit()
            .Columns(2).BestFit()
            .Columns(3).BestFit()
            .Columns(4).BestFit()
            .Columns(5).BestFit()
            .Columns(6).BestFit()
            .Columns(7).BestFit()
            .Columns(8).BestFit()
            .Columns(9).BestFit()
            .Columns(10).BestFit()
            .Columns(11).BestFit()
            .Columns(12).BestFit()
            .Columns(13).BestFit()
            .Columns(14).BestFit()
            .Columns(15).BestFit()
            .Columns(16).BestFit()
            .Columns(17).BestFit()
        End With
    End Sub

    'Set Info displayed on grid
    Public Sub displayRemoved()

        'change header text of the grid
        With Dashboard.gridDriverRemoved
            .Columns(1).HeaderText = "ID No."
            .Columns(2).HeaderText = "Last Name"
            .Columns(3).HeaderText = "First Name"
            .Columns(4).HeaderText = "Middle Name"
            .Columns(5).HeaderText = "License No."
            .Columns(6).HeaderText = "SSS No."
            .Columns(7).HeaderText = "Driver Status"
            .Columns(8).HeaderText = "Assigned Taxi"
            .Columns(9).HeaderText = "Age"
            .Columns(10).HeaderText = "Gender"
            .Columns(11).HeaderText = "Address"
            .Columns(12).HeaderText = "Civil Status"
            .Columns(13).HeaderText = "Mobile No."
            .Columns(14).HeaderText = "Religion"
            .Columns(15).HeaderText = "Contact Person"
            .Columns(16).HeaderText = "Contact Number"

            ''Hide columns
            .Columns(1).IsVisible = False
            '.Columns(9).IsVisible = False
            '.Columns(10).IsVisible = False
            '.Columns(11).IsVisible = False
            '.Columns(12).IsVisible = False
            '.Columns(13).IsVisible = False
            '.Columns(14).IsVisible = False
            '.Columns(15).IsVisible = False
            '.Columns(16).IsVisible = False
            .Columns(17).IsVisible = False
            .Columns(18).IsVisible = False

            'Fit all the columns
            '.Columns(0).BestFit()
            .Columns(1).BestFit()
            .Columns(2).BestFit()
            .Columns(3).BestFit()
            .Columns(4).BestFit()
            .Columns(5).BestFit()
            .Columns(6).BestFit()
            .Columns(7).BestFit()
            .Columns(8).BestFit()
            .Columns(9).BestFit()
            .Columns(10).BestFit()
            .Columns(11).BestFit()
            .Columns(12).BestFit()
            .Columns(13).BestFit()
            .Columns(14).BestFit()
            .Columns(15).BestFit()
            .Columns(16).BestFit()
            .Columns(17).BestFit()
            .Columns(18).BestFit()
        End With
    End Sub

    'Fetching of all drivers information and displays to the gridDriver(GridView)
    Public Sub getAllDriversInfoFromDB()

        'select all drivers info
        selectQuery("select * from tbl_drivers_info where removed='No' order by last_name ASC;")

        If dr.HasRows Then
            'setting datasource
            Dashboard.gridDriver.DataSource = dr
            displayNotRemoved()
        End If
    End Sub

    Public Sub searchDriversFromDB()
        'select all drivers info
        selectQuery("select * from tbl_drivers_info where last_name like '" & Dashboard.txtSearchDriver.Text & "' or first_name like '" & Dashboard.txtSearchDriver.Text & "'  and removed='No' order by last_name ASC ;")

        If dr.HasRows Then
            'setting datasource
            Dashboard.gridDriver.DataSource = dr
            displayNotRemoved()
        End If

    End Sub


    'Fetching of all drivers information and displays to the gridDriver(GridView)
    Public Sub getAllRemovedDriversInfoFromDB()

        'select all drivers info
        selectQuery("select * from tbl_drivers_info where removed='Yes' order by last_name ASC;")

        If dr.HasRows Then
            'setting datasource
            Dashboard.gridDriverRemoved.DataSource = dr
            displayRemoved()
        End If
    End Sub

    Public Sub searchRemovedDriversFromDB()
        'select all drivers info
        selectQuery("select * from tbl_drivers_info where last_name like '" & Dashboard.txtSearchDriverRemoved.Text & "' or first_name like '" & Dashboard.txtSearchDriverRemoved.Text & "'  and removed='Yes' order by last_name ASC ;")

        If dr.HasRows Then
            'setting datasource
            Dashboard.gridDriverRemoved.DataSource = dr
            displayRemoved()
        End If

    End Sub


End Module
