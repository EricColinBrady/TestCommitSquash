    
    
        Dim compare As New SortListArray(True)
        oGroups.Sort(compare)
		StandardMeasure()
		
		
        'added yearBuild update for section items
        'Defect #5404
        For Each oInsp As Inspection_Data In Component_Section.GetByID()

        Next
		
		Component_Section.GetByID(PM, ID.ToString())
		
		PM.GetAllObjects(GetType(Functional_Area), AREA_SQL & "'" & IDString & "'")
		
		            'oFWI.FundingSource = E2F.FundingSource.GetByID(PM, .FundingSource)
            'rcbFundSource.SelectedValue = E2F.FundingSource.GetByID(PM, ).ToString()
			ddlSampleList.SelectedIndex = ViewState.Item(Me.ddlSampleList.SelectedIndex)
			
			

			rtbName.Text = lstTemplates.Items(lstTemplates.SelectedIndex).ToString
			
            If rntbSampleQty.Value <= 0 Then
                Dim confirmscript As String = "<script language='javascript'>" _+
				"function f(){" _+
				"radalert('You must specify a Sample Qty before saving.', 260, 140, 'Warning'); " _+
				"Sys.Application.remove_load(f);};"  _+
				"Sys.Application.add_load(f);" _+
				"function setFocus(FieldID){" _+
				"document.getElementById(FieldID).focus();" _+
				"}" _+
				"</script>"
				
                RadScriptManager1.RegisterStartupScript(Me, Me.[GetType](), "warning", confirmscript, False)
                PM.InventoryDB.RollbackTransaction()
                Return
            End If
			
Me.PageSettings.Orientation = PageOrientation.Landscape
10.97917!

         If e.Item.Value = "Save" Then
            If YearBuilt <> Section.YearBuilt Then
                'handle the changed installed date in this manner so that the prompt only shows when the user goes to save
                'Changed verbiage for defect 5407
                Dim Prompt As String
                If Not ConfigManager.UseUniformat Then
                    Prompt = "Are you sure the " & Replace(Section.Component.ComponentInfo.SectionYearLabel, ":", "") & " date is correct?"
                    'Prompt = "Is  " & wneYearBuilt.Text & " the actual date?"
                Else
                    Prompt = "Are you sure the " & Replace(Section.CMCInfo.ComponentUII.SectionYearLabel, ":", "") & " date is correct?"
                    'Prompt = "Is " & wneYearBuilt.Text & " the actual date?"
                End If
                RunScriptOnStartUp("showConfirm('" & Prompt & "','Estimated Date')")
            Else
                Save()
            End If
        End If
			
			
			
			
			
    ReadOnly Property CanEditInspection As Boolean
        Get
            Dim anInsp As Inspection_Data
            Dim dYearBuilt As String = "01/01/" & Section.YearBuilt.ToString()
            dYearBuilt = Date.Parse(dYearBuilt).Year
            'Convert.ToDateTime(Section.YearBuilt.ToString()).Year

            If Section.InspectionDatas.Count = 0 Then
                Return True
            Else

                For Each anInsp In Section.InspectionDatas
                    If anInsp.InspectionDate.Year >= dYearBuilt Then
                        Return True
                    End If
                Next

                Return False
            End If
        End Get
    End Property			
			
			
'---------------------------------------------
	m_SurfaceInspData = (From id In Me.InspectionDatas.AsQueryable() Select id).FirstOrDefault _
	(Function(idTest) idTest.ComponentSection.CMCInfo.Component.Description.IndexOf _
	("surface", StringComparison.OrdinalIgnoreCase) >= 0)
'---------------------------------------------			
			
			
    ''' <summary>
    ''' Sets Inspection date value.
    ''' </summary>
    ''' <value>Date the inspection was done</value>
    ''' <returns>Returns the Date of the inspection</returns>
    ''' <remarks></remarks>
    Public Property RVIDate As Date
        Get
            If Not SurfaceInspectionData Is Nothing Then
                Return CellValue("INSP_DATA_INSP_DATE") 'SurfaceInspectionData.InspectionDate
            End If
            'Return Now()
        End Get
        Set(ByVal value As Date)
            CellValue("INSP_DATA_INSP_DATE") = value
            'MyBase.InspectionDate = value
        End Set
    End Property
	
OrElse (TypeOf oNewObject Is Building AndAlso CType(oNewObject, Building ).Type = Organization.OrgType.)
			
	Dim rollup As ERDC.CERL.SMS.Web.IndexRollup
	Dim thisSite As Organization

	rollup.PerformRollup()
	
	'Dim roofSection As BuildingBR.RoofSection.GetByID(PM, CellValue("RoofSection_ID"))
	
				
	Sys_comp ...ln.833ish
	                If oSys.SystemInfo.Description.ToLower = "roofing" Then
                    Dim rSec As RoofSection = BuildingBR.RoofSection.GetByID(PM, oSect.RoofSectionID) 'get the RoofSection

                    'Lookup.ROOFER_Code.GetByID(rSec.PM,rSec.)

                    'add the roof Section to the building
                    oSect.Component.System.Building.AddDefaultRoofSection(rSec.Name, _
                           rSec.Area, rSec.RoofCategory, Lookup.RoofCategory.Type.Membrane, _
                           rSec.DateInventoried, rSec.DateBuilt, rSec.DateReplaced)

                End If
                oSect.BuildingCopy(oComp, eCopySectionType, bCopyInspection)
				
				
 '
        'Detail
        '
        'Me.Detail.CanShrink = True
        'Me.Detail.ColumnCount = 4
        'Me.Detail.ColumnSpacing = 1.0!
        'Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1})
        'Me.Detail.Height = 1.0!
        'Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "Distress"
        Me.TextBox1.DistinctField = "Distress"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.LineSpacing = 1.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-size: 6pt; white-space: inherit; "
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.1875!


'---------------------------------------------
        'format string so that it matches the TR-12-15 Metal Panel Roofing Doc  i.e. "Flash Fastener (FF)"
        Dim sDistressTest As String = Mid(Fields("DISTRESS").Value.ToString, 6) & " (" & Fields("RooferCode").Value.ToString & ")"
        'dynamically set size
        Dim tbSize As System.Drawing.SizeF

        tbSize.Width = sDistressTest.Length + 3
        tbSize.Height = 0.25

        TextBox1.Size = tbSize
        TextBox1.MultiLine = True
        TextBox1.LineSpacing = 1.5

        TextBox1.Text = sDistressTest.Trim 'Mid(Fields("DISTRESS").Value.ToString, 6).Trim

        If Fields("ROOFTYPE").Value = 7 Then
            Detail.ColumnDirection = ColumnDirection.DownAcross
            Detail.ColumnCount = 4
            Detail.ColumnSpacing = 1
            Detail.SizeToFit(True)
        End If

  '-------------
            'Metal Panel Defect #5666
            If oRoofSect.RoofCategory.Description.ToUpper = "METAL PANEL" Then
                Me.Label9.Text = "Roofing Type:"
                Me.Label22.Text = ""

                Me.Label10.Text = "Metal Panel Type:"
            End If
   ------------
   
   ''just some crap
   
   
    Private m_RooferXref As DataTable
   
       Public ReadOnly Property RooferXref As DataTable
        Get
            If m_RooferXref Is Nothing Then
                Dim rsSection As RoofSection = m_RoofSection
                Return rsSection.RooferXRef
            End If
            Return m_RooferXref
        End Get

    End Property
   
   '----- fit & finnish ------
   ''' code example from Standards.aspx.vb
   ''' also not that some object will be in tables, others in Div's
   ''' allow for padding 
   Private Const HEADER_AREA As Integer = BANNER_HEADER_AREA + 32
   
   '''---------------------------------------------------------------------------
   
   
           'update the indexes during the save
        MyBase.MCI = MyBase.GetLatestMCI
        MyBase.FCI = MyBase.GetLatestFCI
        MyBase.ICI = ICI
        MyBase.RCI = CI_Manager.CalculateRCI(MyBase.FCI, MyBase.MCI, MyBase.ICI, MyBase.RoofSection.HasInsulation)
		        UpdateRoofSectionIndexes()
        Save()
	'--------------------------------------------------------------
   
if rviCurrentInspection.IsLatestInspection And rviCurrentInspection.Distresses.Count = 0 Then
	idCSInspection = rviCurrentInspection.AddSurfaceInspectionData(dtInspDate) ' add so that surface and flashing will save
End If
   
   
   
' ----------- some Linq stuff --------------

    Function GroupBy(ByVal i_sGroupByColumn As String, ByVal i_sAggregateColumn As String, ByVal i_dSourceTable As DataTable) As DataTable

        Dim aQuery = From row In i_dSourceTable Group By Group1 = row(i_sGroupByColumn)
                     Into Group Select Group1, Aggr = Group.Count(Function(row) row(i_sAggregateColumn))

        Return aQuery.toDataTable

    End Function
							
							
  ----------------------------------------
Private Function isDistressMatch(ByVal distressSet As DataTable) As DataTable
        'make a copy of the DataTable so that the original dataTable stays intact
        Dim dt As DataTable = distressSet.Clone()

        Try
            '''Create a new table of just the Defect data
            Dim query = dt.AsEnumerable() _
                        .Select(Function(defects As DataRow) New With
                        { _
                        .DefectFree = defects.Field(Of String)("DefectFree"), _
                        .DistressSeverity = defects.Field(Of String)("DistressSeverity"), _
                        .DistressDesc = defects.Field(Of String)("DistressDesc"), _
                        .DistressCode = defects.Field(Of String)("DistressCode"), _
                        .DistressQuantity = defects.Field(Of String)("DistressQuantity"), _
                        .RSArea = defects.Field(Of String)("RSArea") _
                        })
            '.Where(Function(n) n.Facility_Name = m_Data("Facility_Name"))

            dt = query.CopyToDataTable()

            '''now look for the matching rows and add them to the distressSet
            Dim duplicates = distressSet.AsEnumerable().GroupBy _
                             (Function(s) s.Field(Of String)("DistressCode")) _
                                  .Where(Function(g) g.Count() > 1).Select(Function(g) g.Key)


            '  (Function(c) c.Field(Of String)("DistressCode")) _
            For Each dup As DataRow In duplicates
                'add the row to the returning DataTable
            Next

            distressSet = duplicates.CopyToDataTable()
            Return distressSet
        Catch ex As Exception

        End Try



    End Function
	
	
        ''' ---- an example ------
        ' Get two rows from the SalesOrderHeader table.

        'Dim left = distressSet.Rows(0)
        'Dim right = distressSet.Rows(1)

        '' Compare the two different rows.
        'Dim comparer As IEqualityComparer(Of DataRow) = DataRowComparer.Default
        'Dim bEqual = comparer.Equals(left, right)

        'If (bEqual = True) Then
        '    'Console.WriteLine("Two rows are equal")
        'Else
        '    'Console.WriteLine("Two rows are not equal")
        'End If	
   
   
   areas to look at for Flashing Distresses

    Public ReadOnly Property FlashingSubComp() As Sample_Subcomponent
        Get
            If FlashingSample Is Nothing Then Return Nothing
            Return FlashingSample.Subcomponents.OrderBy(Function(sc) sc.CMCSubComponentInfo.ID).First()
        End Get
    End Property
-----------------------
	    Public ReadOnly Property Subcomponents() As List(Of Sample_Subcomponent)
        Get
            If m_SampleSubComponents Is Nothing Then
                m_SampleSubComponents = PM.GetAllObjects(Of Sample_Subcomponent)(SUBCOMPS_SQL & "'" & IDString & "'")
                ' ORDER BY SAMP_SUBCOMP_CMC_SUBCOMP_LINK")

            End If
            Return m_SampleSubComponents
        End Get
    End Property
--------------------------
    Public ReadOnly Property RooferDistressSet(ByVal oRoofType As RoofType) As List(Of Distress)
        Get
            'm_DistressSet = Nothing

            If m_DistressSet Is Nothing Then
                'JDA: you can not trust the Distress_Set value - not sure why
                'use the first distress to determine the distress set
                'RN: This method fails if there are no records in RO_SComp_Dist for a given ID.  
                'Perhaps we should revisit this issue and clean up the RO_SComp_Dist table instead of hiding the error.
                If Distresses.Count > 0 Then
                    m_DistressSet = PM.GetAllObjects(Of Distress)(DISTRESS_SET_SQL & Distresses(0).DistressSet & " AND [RoofType]=" & oRoofType.ID.ToString)
                Else
                    m_DistressSet = New List(Of Distress)
                End If
            End If
            Return m_DistressSet
        End Get
    End Property
--------------------------------------	
    Public ReadOnly Property Distresses() As List(Of Distress)
        Get
            If m_Distresses Is Nothing Then
                m_Distresses = PM.GetAllObjects(Of Distress)(DISTRESS_SQL & "'" & ID & "'")
            End If
            Return m_Distresses
        End Get
    End Property
----------------------------------------
	
		(New System.Collections.Generic.Mscorlib_CollectionDebugView(Of ERDC.CERL.SMS.Libraries.Data.Lookup.CMC_SubComp)(distressCurrent.CMCSubcomponents)).Items(0).CMCInfo.ID	) expected	


------------------------------------------

    Protected Sub rtbRoofInspections_ButtonClick(sender As Object, e As RadToolBarEventArgs) Handles rtbRoofInspections.ButtonClick
        If e.Item.Text = "Add" Then
            ValidateGeneral()
            ValidateLayout()
            ValidateCoveringType()
        End If

    End Sub


	       public String StatusName
        {
            
            get { return Enum.GetName(typeof(Status.StatusType), Status); }
            //set;
        }
		
		
		
		//StatusName = Enum.GetName(typeof(Status.StatusType), pair.WorkItem.Status)
		
		roofSchema = 139
		
		
		
		
		
		
        Select Case e.Item.Text
            Case "Add"
                If Not ValidateSave() Then Return

                Dim oRI As BuildingBR.RoofInspection = Section.FindOrAddInspectionByType(rdpInspDate.SelectedDate, ddlInspType.SelectedValue)

                If Not oRI Is Nothing Then
                    If oRI.IsLatestInspection Then
                        If Not oRI.Type = RooferInspectionType.InspectionType.Insulation Then
                            ''EcB 03/07/2015
                            '' when creating a Insulation Inspection, the prior Visual inspection
                            '' was deleting the Curb/Perimeter qnt values, in turn resetting the
                            '' FCI to 0/-1. By setting the qnt values back to the section values
                            '' the current qnt are saved

                            Section.FlashingPerimeterLength = SaveQuantity(PM, rntPermFlashing.Value, Lookup.Units_Conversion.UnitType.LinearUnits, UserAccount.UnitSystemPreference)
                            Section.FlashingCurbLength = SaveQuantity(PM, rntCurbFlashing.Value, Lookup.Units_Conversion.UnitType.LinearUnits, UserAccount.UnitSystemPreference)

                            If Section.RoofCategory.Type.MetalPanel Then
                                Section.ThruPanelFasteners = SaveQuantity(PM, rntThruPanelFasteners.Value, Lookup.Units_Conversion.UnitType.EA, UserAccount.UnitSystemPreference)
                            End If
                        Else
                            Section.FlashingPerimeterLength = SaveQuantity(PM, Section.FlashingPerimeterLength, Lookup.Units_Conversion.UnitType.LinearUnits, UserAccount.UnitSystemPreference)
                            Section.FlashingCurbLength = SaveQuantity(PM, Section.FlashingCurbLength, Lookup.Units_Conversion.UnitType.LinearUnits, UserAccount.UnitSystemPreference)

                        End If


                        'update the RCI and other indexes since a new inspection has been added
                        Dim oCiMngr As New CI_Manager(PM)
                        oCiMngr.RollupRoofSection(Section)
                    End If
                Else
                    Throw New Exception("Unable to create a valid roof inspection.")
                End If

                'and close
                Me.CloseRadWindow("-") 'return something so that the grid will refresh
        End Select
		
		
		
		
		
        For Each flashingToUpdate In RoofFlashings
            Dim flashingKvp = dictFlashingQuantity.Where(Function(kvp) kvp.Key.ID = flashingToUpdate.RooferCodeInfo.ID).FirstOrDefault()
            flashingToUpdate.Quantity = E2F.Measure.SaveQuantity(PM, flashingKvp.Value, flashingToUpdate.RooferCodeInfo.UoM.GetValueOrDefault(Units_Conversion.UnitType.LinearUnits), usUserUnitSystem)
            dictFlashingQuantity.Remove(flashingKvp.Key)
            PM.UpdateObject(flashingToUpdate)
        Next

        ' Create a new RoofSectionRooferCode for anything remaining
        For Each kvp As KeyValuePair(Of IROOFER_Code, Double) In dictFlashingQuantity
            Dim rsrcNew As RoofSectionRooferCode = FindOrAddRoofSectionRooferCode(typeOfRoofSectionRooferCode, kvp.Key)
            rsrcNew.Quantity = E2F.Measure.SaveQuantity(PM, kvp.Value, kvp.Key.UoM.GetValueOrDefault(Units_Conversion.UnitType.LinearUnits), usUserUnitSystem)
            PM.UpdateObject(rsrcNew)
        Next		
		
		

Dim coolRoofRequest as new ORNLRoofService.cool_roof_request With
                   {
                       .heating_system_fuel_type = getFuelTypeValue(Me.heating_system_fuel_type),
                       .weather_location = getLocationValue(Me.weather_location),
                       .r_value = Me.r_value,
                       .solar_reflectance = Me.solar_reflectance,
                       .thermal_emittance = Me.thermal_emittance,
                       .heating_system_efficiency = Me.heating_system_efficiency,
                       .heating_fuel_cost = Me.heating_fuel_cost,
                       .cooling_system_efficiency = Me.cooling_system_efficiency,
                       .cooling_fuel_cost = Me.cooling_fuel_cost
                   }

                Dim coolReq = New ORNLRoofService.coolRoofRequest With {.cool_roof_request = coolRoofRequest}
                Dim coolReturn = roofCalc.coolRoof(coolReq)

                ''-------------------- Return values  cool --------------------------------------
                Me.cooling_load_black = coolReturn.cool_roof_response.cooling_load_black
                Me.heating_load_black = coolReturn.cool_roof_response.heating_load_black
                Me.cooling_load_proposed = coolReturn.cool_roof_response.cooling_load_proposed
                Me.heating_load_proposed = coolReturn.cool_roof_response.heating_load_proposed
                Me.net_savings = coolReturn.cool_roof_response.net_savings
                Me.cooling_savings = coolReturn.cool_roof_response.cooling_savings
                Me.heating_savings = coolReturn.cool_roof_response.heating_savings
                Me.r_value_upgrade = coolReturn.cool_roof_response.r_value_upgrade
                ''------------------------------------------------------------------------------

		

placeList.Add(New LocationPlace() With {
.ID = 234, _
 .LocCity = "Sheridan", _
 .LocElevation = "1209", _
 .LocLatitude = "44.766666666666666", _
 .Loclongitude = "-106.96666666666667", _
 .LocState = "WY"
 })
 
 ''This should get a list of roof sections from any selection level:


C:\Program Files (x86)\Microsoft Office\Office15\Library\SOLVER\SOLVER.XLAM
		

Sub OnErrorStatementDemo() 
 On Error GoTo ErrorHandler ' Enable error-handling routine. 
 Open "TESTFILE" For Output As #1 ' Open file for output. 
 Kill "TESTFILE" ' Attempt to delete open 
 ' file. 
 On Error Goto 0 ' Turn off error trapping. 
 On Error Resume Next ' Defer error trapping. 
 ObjectRef = GetObject("MyWord.Basic") ' Try to start nonexistent 
 ' object, then test for 
'Check for likely Automation errors. 
 If Err.Number = 440 Or Err.Number = 432 Then 
 ' Tell user what happened. Then clear the Err object. 
 Msg = "There was an error attempting to open the Automation object!" 
 MsgBox Msg, , "Deferred Error Test" 
 Err.Clear ' Clear Err object fields 
 End If 
Exit Sub ' Exit to avoid handler. 
ErrorHandler: ' Error-handling routine. 
 Select Case Err.Number ' Evaluate error number. 
 Case 55 ' "File already open" error. 
 Close #1 ' Close open file. 
 Case Else 
 ' Handle other situations here... 
 End Select 
 Resume ' Resume execution at same line 
 ' that caused the error. 
End Sub 


'
Sub runSolver()
    On Error GoTo Error_Catching
    
    Range("AC54").Select
    ActiveCell.FormulaR1C1 = "unsolved"
' add code for solver execuation
    SolverOk SetCell:="$AA$54", MaxMinVal:=2, ValueOf:=0, ByChange:="$D$4:$D$53", _
        Engine:=3, EngineDesc:="Evolutionary"
    
 '   SolverOk SetCell:="$AA$54", MaxMinVal:=2, ValueOf:=0, ByChange:="$D$4:$D$53", _
 '       Engine:=3, EngineDesc:="Evolutionary"
    SolverSolve UserFinish:=True
    SolverFinish KeepFinal:=1
        
' end solver
    Range("AC54").Select
    ActiveCell.FormulaR1C1 = "solved"
    'Range("AC55").Select
    
Error_Catching:
    errMsgString = "Work item Error: " & Err.Number & " - " & Err.Description
    
    Range("AC55").Select
    ActiveCell.FormulaR1C1 = errMsgString
    
    MsgBox Msg, vbOKOnly, "Work Item Error", , errMsgString
    Err.Clear
    ActiveCell.FormulaR1C1 = ""
    
    Resume Next
End Sub


 

 

 
    Public Shared Function Computek(ByVal iCI As Double, _
                             ByVal iCIYear As Integer, _
                             ByVal iDesignLife As Short, _
                             ByVal iYearReplaced As Integer) As Double
        Dim Age As Integer
        Dim _k As Double
        Age = iCIYear - iYearReplaced

        _k = (100 - iCI) / (Age * Age)

        If _k < 0.1675 OrElse Age = 0 Then _k = 0.1675
        Return _k

    End Function


 
		
		
		
		
    Public Shared Function SafeImageFromFile(ByVal fileName As String) As System.Drawing.Image
        Dim strFileNameActual As String = GetLocalFilePath(fileName)
        Dim imgResult As System.Drawing.Image = Nothing
        Dim imgTemp As System.Drawing.Image
        Using wc As New System.Net.WebClient()
            Dim bytes As Byte() = wc.DownloadData(strFileNameActual)
            Using ms As New MemoryStream(bytes)
                imgTemp = System.Drawing.Image.FromStream(ms)
                Dim gResult As System.Drawing.Graphics

                If TypeOf imgTemp Is System.Drawing.Bitmap Then
                    Try
                        imgResult = New System.Drawing.Bitmap(imgTemp.Width, imgTemp.Height)
                        gResult = System.Drawing.Graphics.FromImage(imgResult)
                        gResult.DrawImage(imgTemp, 0, 0, imgTemp.Width, imgTemp.Height)
                    Finally
                        DirectCast(gResult, IDisposable).Dispose()
                    End Try
                End If
            End Using
        End Using
        imgTemp.Dispose()
        Return imgResult
    End Function
		
		
		
		    Protected Sub LoadDropDown(ByRef ddl As DropDownList, ByVal eCodeType As RooferCodeType.CodeType)
        ddl.ClearSelection()
        ddl.Items.Clear()

        Dim oRCT As RooferCodeType = RooferCodeType.GetByID(PM, eCodeType)
        if IsNothing(oRCT)
            ddl.Items.Insert(0, New ListItem("Failed to load data", -1))
            exit sub
        End If
            oRCT.RooferCodes.Sort()
            ddl.DataSource = oRCT.RooferCodes
            ddl.DataValueField = "ID"
            ddl.DataTextField = "Description"
            ddl.DataBind()
            'insert a blank item that can be used to show the null values
            ddl.Items.Insert(0, New ListItem("", -1))
    End Sub
	
	

		public Function getMeNow(byVal meme as Object) as DataTable
            dim myName as String
            Dim mySelf as Boolean
            Dim fall as Date
            Dim Jump as dataTable

            While mySelf

                set mySelf.jump = jump
                if fall < now then
                    mySelf = False
                Else
                    MySelf = True
                end if

            End While

            meme.item.add(0)="this"
            meme.item.add(1)="and"
            meme.item.add(2)="that"

            for i as Integer = 0 to meme.Count
                jump.add(meme(i))
            Next

            Return jump

        end Function
		
		
		