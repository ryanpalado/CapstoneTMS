Module TaxiInfoModule
    Public Sub getAllTaxiInfoFromDB()


        selectQuery("select * from tbl_taxi_info")

        If dr.HasRows Then
            'setting datasource
            Dashboard.gridTaxi.DataSource = dr
            showColumnTaxi()
        Else
            Dashboard.gridTaxi.DataSource = dr
            showColumnTaxi()
        End If
    End Sub

    Public Sub showColumnTaxi()
        With Dashboard.gridTaxi
            .Columns(2).HeaderText = "Taxi No."
            .Columns(3).HeaderText = "Plate No."
            .Columns(4).HeaderText = "Chassis No."
            .Columns(5).HeaderText = "Brand Name"
            .Columns(6).HeaderText = "Year Model"
            .Columns(7).HeaderText = "Registration Date"
            .Columns(8).HeaderText = "Registration Expiration"
            .Columns(9).HeaderText = "Renewal Date"
            .Columns(10).HeaderText = "Franchise Date"
            .Columns(11).HeaderText = "Franchise Expiration"
            .Columns(12).HeaderText = "First Meter Checking"
            .Columns(13).HeaderText = "Second Meter Checking"
            .Columns(14).HeaderText = "Coding Day"
            .Columns(15).HeaderText = "Taxi Status"
            .Columns(16).HeaderText = "Driver"


            ''Hide columns
            .Columns(2).IsVisible = False
            .Columns(7).IsVisible = False
            .Columns(8).IsVisible = False

            .Columns(9).IsVisible = False
            .Columns(10).IsVisible = False
            .Columns(11).IsVisible = False
            .Columns(12).IsVisible = False
            .Columns(13).IsVisible = False
            .Columns(14).IsVisible = False
            ' .Columns(15).IsVisible = False
            .Columns(16).IsVisible = False
            '.Columns(18).IsVisible = False
            '.Columns(19).IsVisible = False

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
End Module
