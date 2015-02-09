VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form FrmMain 
   Caption         =   " ver. 2014/10/30"
   ClientHeight    =   11265
   ClientLeft      =   570
   ClientTop       =   450
   ClientWidth     =   14205
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "TCP.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   11265
   ScaleWidth      =   14205
   Begin TabDlg.SSTab SSTab1 
      Height          =   8295
      Left            =   0
      TabIndex        =   41
      Top             =   840
      Width           =   14205
      _ExtentX        =   25056
      _ExtentY        =   14631
      _Version        =   393216
      Tabs            =   4
      TabsPerRow      =   4
      TabHeight       =   520
      TabCaption(0)   =   "Tab 0"
      TabPicture(0)   =   "TCP.frx":0442
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "Label20(7)"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "LabRcv(7)"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "LabLoss(7)"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).Control(3)=   "Label24(7)"
      Tab(0).Control(3).Enabled=   0   'False
      Tab(0).Control(4)=   "LabSend(7)"
      Tab(0).Control(4).Enabled=   0   'False
      Tab(0).Control(5)=   "Label20(6)"
      Tab(0).Control(5).Enabled=   0   'False
      Tab(0).Control(6)=   "LabRcv(6)"
      Tab(0).Control(6).Enabled=   0   'False
      Tab(0).Control(7)=   "LabLoss(6)"
      Tab(0).Control(7).Enabled=   0   'False
      Tab(0).Control(8)=   "Label24(6)"
      Tab(0).Control(8).Enabled=   0   'False
      Tab(0).Control(9)=   "LabSend(6)"
      Tab(0).Control(9).Enabled=   0   'False
      Tab(0).Control(10)=   "Label20(5)"
      Tab(0).Control(10).Enabled=   0   'False
      Tab(0).Control(11)=   "LabRcv(5)"
      Tab(0).Control(11).Enabled=   0   'False
      Tab(0).Control(12)=   "LabLoss(5)"
      Tab(0).Control(12).Enabled=   0   'False
      Tab(0).Control(13)=   "Label24(5)"
      Tab(0).Control(13).Enabled=   0   'False
      Tab(0).Control(14)=   "LabSend(5)"
      Tab(0).Control(14).Enabled=   0   'False
      Tab(0).Control(15)=   "Label20(4)"
      Tab(0).Control(15).Enabled=   0   'False
      Tab(0).Control(16)=   "LabRcv(4)"
      Tab(0).Control(16).Enabled=   0   'False
      Tab(0).Control(17)=   "LabLoss(4)"
      Tab(0).Control(17).Enabled=   0   'False
      Tab(0).Control(18)=   "Label24(4)"
      Tab(0).Control(18).Enabled=   0   'False
      Tab(0).Control(19)=   "LabSend(4)"
      Tab(0).Control(19).Enabled=   0   'False
      Tab(0).Control(20)=   "Label20(3)"
      Tab(0).Control(20).Enabled=   0   'False
      Tab(0).Control(21)=   "LabRcv(3)"
      Tab(0).Control(21).Enabled=   0   'False
      Tab(0).Control(22)=   "LabLoss(3)"
      Tab(0).Control(22).Enabled=   0   'False
      Tab(0).Control(23)=   "Label24(3)"
      Tab(0).Control(23).Enabled=   0   'False
      Tab(0).Control(24)=   "LabSend(3)"
      Tab(0).Control(24).Enabled=   0   'False
      Tab(0).Control(25)=   "Label29(0)"
      Tab(0).Control(25).Enabled=   0   'False
      Tab(0).Control(26)=   "Label28(0)"
      Tab(0).Control(26).Enabled=   0   'False
      Tab(0).Control(27)=   "Label27(0)"
      Tab(0).Control(27).Enabled=   0   'False
      Tab(0).Control(28)=   "Label26(0)"
      Tab(0).Control(28).Enabled=   0   'False
      Tab(0).Control(29)=   "Label25(0)"
      Tab(0).Control(29).Enabled=   0   'False
      Tab(0).Control(30)=   "Label23(0)"
      Tab(0).Control(30).Enabled=   0   'False
      Tab(0).Control(31)=   "LabSend(2)"
      Tab(0).Control(31).Enabled=   0   'False
      Tab(0).Control(32)=   "Label24(2)"
      Tab(0).Control(32).Enabled=   0   'False
      Tab(0).Control(33)=   "LabLoss(2)"
      Tab(0).Control(33).Enabled=   0   'False
      Tab(0).Control(34)=   "Label22(2)"
      Tab(0).Control(34).Enabled=   0   'False
      Tab(0).Control(35)=   "LabRcv(2)"
      Tab(0).Control(35).Enabled=   0   'False
      Tab(0).Control(36)=   "Label20(2)"
      Tab(0).Control(36).Enabled=   0   'False
      Tab(0).Control(37)=   "Label19(0)"
      Tab(0).Control(37).Enabled=   0   'False
      Tab(0).Control(38)=   "LabSend(1)"
      Tab(0).Control(38).Enabled=   0   'False
      Tab(0).Control(39)=   "Label20(1)"
      Tab(0).Control(39).Enabled=   0   'False
      Tab(0).Control(40)=   "LabRcv(1)"
      Tab(0).Control(40).Enabled=   0   'False
      Tab(0).Control(41)=   "LabLoss(1)"
      Tab(0).Control(41).Enabled=   0   'False
      Tab(0).Control(42)=   "Label24(1)"
      Tab(0).Control(42).Enabled=   0   'False
      Tab(0).Control(43)=   "LabLoss(0)"
      Tab(0).Control(43).Enabled=   0   'False
      Tab(0).Control(44)=   "LabRcv(0)"
      Tab(0).Control(44).Enabled=   0   'False
      Tab(0).Control(45)=   "Label20(0)"
      Tab(0).Control(45).Enabled=   0   'False
      Tab(0).Control(46)=   "LabSend(0)"
      Tab(0).Control(46).Enabled=   0   'False
      Tab(0).Control(47)=   "Label17(0)"
      Tab(0).Control(47).Enabled=   0   'False
      Tab(0).Control(48)=   "Label16(0)"
      Tab(0).Control(48).Enabled=   0   'False
      Tab(0).Control(49)=   "Label15(0)"
      Tab(0).Control(49).Enabled=   0   'False
      Tab(0).Control(50)=   "Label12(0)"
      Tab(0).Control(50).Enabled=   0   'False
      Tab(0).Control(51)=   "Label5(0)"
      Tab(0).Control(51).Enabled=   0   'False
      Tab(0).Control(52)=   "Label8(0)"
      Tab(0).Control(52).Enabled=   0   'False
      Tab(0).Control(53)=   "Label22(0)"
      Tab(0).Control(53).Enabled=   0   'False
      Tab(0).Control(54)=   "Label24(0)"
      Tab(0).Control(54).Enabled=   0   'False
      Tab(0).Control(55)=   "Label22(1)"
      Tab(0).Control(55).Enabled=   0   'False
      Tab(0).Control(56)=   "Label4(0)"
      Tab(0).Control(56).Enabled=   0   'False
      Tab(0).Control(57)=   "Label2(0)"
      Tab(0).Control(57).Enabled=   0   'False
      Tab(0).Control(58)=   "TxtRcvPket(7)"
      Tab(0).Control(58).Enabled=   0   'False
      Tab(0).Control(59)=   "TxtSendPket(7)"
      Tab(0).Control(59).Enabled=   0   'False
      Tab(0).Control(60)=   "TxtSendPketTal(7)"
      Tab(0).Control(60).Enabled=   0   'False
      Tab(0).Control(61)=   "TxtCntSendTal(7)"
      Tab(0).Control(61).Enabled=   0   'False
      Tab(0).Control(62)=   "TxtCntSend(7)"
      Tab(0).Control(62).Enabled=   0   'False
      Tab(0).Control(63)=   "TxtCntRcv(7)"
      Tab(0).Control(63).Enabled=   0   'False
      Tab(0).Control(64)=   "TxtCntLoss(7)"
      Tab(0).Control(64).Enabled=   0   'False
      Tab(0).Control(65)=   "CmdSendBeg(7)"
      Tab(0).Control(65).Enabled=   0   'False
      Tab(0).Control(66)=   "TxtSendDataLen(7)"
      Tab(0).Control(66).Enabled=   0   'False
      Tab(0).Control(67)=   "TxtSendIntval(7)"
      Tab(0).Control(67).Enabled=   0   'False
      Tab(0).Control(68)=   "TxtSendData(7)"
      Tab(0).Control(68).Enabled=   0   'False
      Tab(0).Control(69)=   "TxtRcvPket(6)"
      Tab(0).Control(69).Enabled=   0   'False
      Tab(0).Control(70)=   "TxtSendPket(6)"
      Tab(0).Control(70).Enabled=   0   'False
      Tab(0).Control(71)=   "TxtSendPketTal(6)"
      Tab(0).Control(71).Enabled=   0   'False
      Tab(0).Control(72)=   "TxtCntSendTal(6)"
      Tab(0).Control(72).Enabled=   0   'False
      Tab(0).Control(73)=   "TxtCntSend(6)"
      Tab(0).Control(73).Enabled=   0   'False
      Tab(0).Control(74)=   "TxtCntRcv(6)"
      Tab(0).Control(74).Enabled=   0   'False
      Tab(0).Control(75)=   "TxtCntLoss(6)"
      Tab(0).Control(75).Enabled=   0   'False
      Tab(0).Control(76)=   "CmdSendBeg(6)"
      Tab(0).Control(76).Enabled=   0   'False
      Tab(0).Control(77)=   "TxtSendDataLen(6)"
      Tab(0).Control(77).Enabled=   0   'False
      Tab(0).Control(78)=   "TxtSendIntval(6)"
      Tab(0).Control(78).Enabled=   0   'False
      Tab(0).Control(79)=   "TxtSendData(6)"
      Tab(0).Control(79).Enabled=   0   'False
      Tab(0).Control(80)=   "TxtRcvPket(5)"
      Tab(0).Control(80).Enabled=   0   'False
      Tab(0).Control(81)=   "TxtSendPket(5)"
      Tab(0).Control(81).Enabled=   0   'False
      Tab(0).Control(82)=   "TxtSendPketTal(5)"
      Tab(0).Control(82).Enabled=   0   'False
      Tab(0).Control(83)=   "TxtCntSendTal(5)"
      Tab(0).Control(83).Enabled=   0   'False
      Tab(0).Control(84)=   "TxtCntSend(5)"
      Tab(0).Control(84).Enabled=   0   'False
      Tab(0).Control(85)=   "TxtCntRcv(5)"
      Tab(0).Control(85).Enabled=   0   'False
      Tab(0).Control(86)=   "TxtCntLoss(5)"
      Tab(0).Control(86).Enabled=   0   'False
      Tab(0).Control(87)=   "CmdSendBeg(5)"
      Tab(0).Control(87).Enabled=   0   'False
      Tab(0).Control(88)=   "TxtSendDataLen(5)"
      Tab(0).Control(88).Enabled=   0   'False
      Tab(0).Control(89)=   "TxtSendIntval(5)"
      Tab(0).Control(89).Enabled=   0   'False
      Tab(0).Control(90)=   "TxtSendData(5)"
      Tab(0).Control(90).Enabled=   0   'False
      Tab(0).Control(91)=   "TxtRcvPket(4)"
      Tab(0).Control(91).Enabled=   0   'False
      Tab(0).Control(92)=   "TxtSendPket(4)"
      Tab(0).Control(92).Enabled=   0   'False
      Tab(0).Control(93)=   "TxtSendPketTal(4)"
      Tab(0).Control(93).Enabled=   0   'False
      Tab(0).Control(94)=   "TxtCntSendTal(4)"
      Tab(0).Control(94).Enabled=   0   'False
      Tab(0).Control(95)=   "TxtCntSend(4)"
      Tab(0).Control(95).Enabled=   0   'False
      Tab(0).Control(96)=   "TxtCntRcv(4)"
      Tab(0).Control(96).Enabled=   0   'False
      Tab(0).Control(97)=   "TxtCntLoss(4)"
      Tab(0).Control(97).Enabled=   0   'False
      Tab(0).Control(98)=   "CmdSendBeg(4)"
      Tab(0).Control(98).Enabled=   0   'False
      Tab(0).Control(99)=   "TxtSendDataLen(4)"
      Tab(0).Control(99).Enabled=   0   'False
      Tab(0).Control(100)=   "TxtSendIntval(4)"
      Tab(0).Control(100).Enabled=   0   'False
      Tab(0).Control(101)=   "TxtSendData(4)"
      Tab(0).Control(101).Enabled=   0   'False
      Tab(0).Control(102)=   "TxtRcvPket(3)"
      Tab(0).Control(102).Enabled=   0   'False
      Tab(0).Control(103)=   "TxtSendPket(3)"
      Tab(0).Control(103).Enabled=   0   'False
      Tab(0).Control(104)=   "TxtSendPketTal(3)"
      Tab(0).Control(104).Enabled=   0   'False
      Tab(0).Control(105)=   "TxtCntSendTal(3)"
      Tab(0).Control(105).Enabled=   0   'False
      Tab(0).Control(106)=   "TxtCntSend(3)"
      Tab(0).Control(106).Enabled=   0   'False
      Tab(0).Control(107)=   "TxtCntRcv(3)"
      Tab(0).Control(107).Enabled=   0   'False
      Tab(0).Control(108)=   "TxtCntLoss(3)"
      Tab(0).Control(108).Enabled=   0   'False
      Tab(0).Control(109)=   "CmdSendBeg(3)"
      Tab(0).Control(109).Enabled=   0   'False
      Tab(0).Control(110)=   "TxtSendDataLen(3)"
      Tab(0).Control(110).Enabled=   0   'False
      Tab(0).Control(111)=   "TxtSendIntval(3)"
      Tab(0).Control(111).Enabled=   0   'False
      Tab(0).Control(112)=   "TxtSendData(3)"
      Tab(0).Control(112).Enabled=   0   'False
      Tab(0).Control(113)=   "TxtSendData(2)"
      Tab(0).Control(113).Enabled=   0   'False
      Tab(0).Control(114)=   "TxtSendIntval(2)"
      Tab(0).Control(114).Enabled=   0   'False
      Tab(0).Control(115)=   "TxtSendDataLen(2)"
      Tab(0).Control(115).Enabled=   0   'False
      Tab(0).Control(116)=   "CmdSendBeg(2)"
      Tab(0).Control(116).Enabled=   0   'False
      Tab(0).Control(117)=   "TxtCntLoss(2)"
      Tab(0).Control(117).Enabled=   0   'False
      Tab(0).Control(118)=   "TxtCntRcv(2)"
      Tab(0).Control(118).Enabled=   0   'False
      Tab(0).Control(119)=   "TxtCntSend(2)"
      Tab(0).Control(119).Enabled=   0   'False
      Tab(0).Control(120)=   "TxtCntSendTal(2)"
      Tab(0).Control(120).Enabled=   0   'False
      Tab(0).Control(121)=   "TxtSendPketTal(2)"
      Tab(0).Control(121).Enabled=   0   'False
      Tab(0).Control(122)=   "TxtSendPket(2)"
      Tab(0).Control(122).Enabled=   0   'False
      Tab(0).Control(123)=   "TxtRcvPket(2)"
      Tab(0).Control(123).Enabled=   0   'False
      Tab(0).Control(124)=   "TxtRcvPket(1)"
      Tab(0).Control(124).Enabled=   0   'False
      Tab(0).Control(125)=   "TxtSendPket(1)"
      Tab(0).Control(125).Enabled=   0   'False
      Tab(0).Control(126)=   "TxtSendPketTal(1)"
      Tab(0).Control(126).Enabled=   0   'False
      Tab(0).Control(127)=   "TxtRcvPket(0)"
      Tab(0).Control(127).Enabled=   0   'False
      Tab(0).Control(128)=   "TxtSendPket(0)"
      Tab(0).Control(128).Enabled=   0   'False
      Tab(0).Control(129)=   "TxtSendPketTal(0)"
      Tab(0).Control(129).Enabled=   0   'False
      Tab(0).Control(130)=   "TxtCntSendTal(0)"
      Tab(0).Control(130).Enabled=   0   'False
      Tab(0).Control(131)=   "TxtCntSendTal(1)"
      Tab(0).Control(131).Enabled=   0   'False
      Tab(0).Control(132)=   "TxtCntSend(1)"
      Tab(0).Control(132).Enabled=   0   'False
      Tab(0).Control(133)=   "TxtCntRcv(1)"
      Tab(0).Control(133).Enabled=   0   'False
      Tab(0).Control(134)=   "TxtCntLoss(1)"
      Tab(0).Control(134).Enabled=   0   'False
      Tab(0).Control(135)=   "CmdSendBeg(1)"
      Tab(0).Control(135).Enabled=   0   'False
      Tab(0).Control(136)=   "TxtSendDataLen(1)"
      Tab(0).Control(136).Enabled=   0   'False
      Tab(0).Control(137)=   "TxtSendIntval(1)"
      Tab(0).Control(137).Enabled=   0   'False
      Tab(0).Control(138)=   "TxtCntLoss(0)"
      Tab(0).Control(138).Enabled=   0   'False
      Tab(0).Control(139)=   "TxtCntRcv(0)"
      Tab(0).Control(139).Enabled=   0   'False
      Tab(0).Control(140)=   "TxtCntSend(0)"
      Tab(0).Control(140).Enabled=   0   'False
      Tab(0).Control(141)=   "CmdSendBeg(0)"
      Tab(0).Control(141).Enabled=   0   'False
      Tab(0).Control(142)=   "TxtSendData(0)"
      Tab(0).Control(142).Enabled=   0   'False
      Tab(0).Control(143)=   "TxtSendDataLen(0)"
      Tab(0).Control(143).Enabled=   0   'False
      Tab(0).Control(144)=   "TxtSendIntval(0)"
      Tab(0).Control(144).Enabled=   0   'False
      Tab(0).Control(145)=   "Frame1(0)"
      Tab(0).Control(145).Enabled=   0   'False
      Tab(0).Control(146)=   "TxtSendData(1)"
      Tab(0).Control(146).Enabled=   0   'False
      Tab(0).Control(147)=   "TmrSend(7)"
      Tab(0).Control(147).Enabled=   0   'False
      Tab(0).Control(148)=   "TmrSend(6)"
      Tab(0).Control(148).Enabled=   0   'False
      Tab(0).Control(149)=   "TmrSend(5)"
      Tab(0).Control(149).Enabled=   0   'False
      Tab(0).Control(150)=   "TmrSend(4)"
      Tab(0).Control(150).Enabled=   0   'False
      Tab(0).Control(151)=   "TmrSend(3)"
      Tab(0).Control(151).Enabled=   0   'False
      Tab(0).Control(152)=   "TmrSend(2)"
      Tab(0).Control(152).Enabled=   0   'False
      Tab(0).Control(153)=   "TmrSend(1)"
      Tab(0).Control(153).Enabled=   0   'False
      Tab(0).Control(154)=   "TmrSend(0)"
      Tab(0).Control(154).Enabled=   0   'False
      Tab(0).Control(155)=   "CmdClrCnt(7)"
      Tab(0).Control(155).Enabled=   0   'False
      Tab(0).Control(156)=   "CmdClrCnt(6)"
      Tab(0).Control(156).Enabled=   0   'False
      Tab(0).Control(157)=   "CmdClrCnt(5)"
      Tab(0).Control(157).Enabled=   0   'False
      Tab(0).Control(158)=   "CmdClrCnt(4)"
      Tab(0).Control(158).Enabled=   0   'False
      Tab(0).Control(159)=   "CmdClrCnt(3)"
      Tab(0).Control(159).Enabled=   0   'False
      Tab(0).Control(160)=   "CmdClrCnt(2)"
      Tab(0).Control(160).Enabled=   0   'False
      Tab(0).Control(161)=   "CmdClrCnt(1)"
      Tab(0).Control(161).Enabled=   0   'False
      Tab(0).Control(162)=   "CmdClrCnt(0)"
      Tab(0).Control(162).Enabled=   0   'False
      Tab(0).ControlCount=   163
      TabCaption(1)   =   "Tab 1"
      TabPicture(1)   =   "TCP.frx":045E
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Label2(1)"
      Tab(1).Control(1)=   "Label4(1)"
      Tab(1).Control(2)=   "Label22(3)"
      Tab(1).Control(3)=   "Label24(8)"
      Tab(1).Control(4)=   "Label22(4)"
      Tab(1).Control(5)=   "Label8(1)"
      Tab(1).Control(6)=   "Label5(1)"
      Tab(1).Control(7)=   "Label12(1)"
      Tab(1).Control(8)=   "Label15(1)"
      Tab(1).Control(9)=   "Label16(1)"
      Tab(1).Control(10)=   "Label17(1)"
      Tab(1).Control(11)=   "LabSend(8)"
      Tab(1).Control(12)=   "Label20(8)"
      Tab(1).Control(13)=   "LabRcv(8)"
      Tab(1).Control(14)=   "LabLoss(8)"
      Tab(1).Control(15)=   "Label24(9)"
      Tab(1).Control(16)=   "LabLoss(9)"
      Tab(1).Control(17)=   "LabRcv(9)"
      Tab(1).Control(18)=   "Label20(9)"
      Tab(1).Control(19)=   "LabSend(9)"
      Tab(1).Control(20)=   "Label19(1)"
      Tab(1).Control(21)=   "Label20(10)"
      Tab(1).Control(22)=   "LabRcv(10)"
      Tab(1).Control(23)=   "Label22(5)"
      Tab(1).Control(24)=   "LabLoss(10)"
      Tab(1).Control(25)=   "Label24(10)"
      Tab(1).Control(26)=   "LabSend(10)"
      Tab(1).Control(27)=   "Label23(1)"
      Tab(1).Control(28)=   "Label25(1)"
      Tab(1).Control(29)=   "Label26(1)"
      Tab(1).Control(30)=   "Label27(1)"
      Tab(1).Control(31)=   "Label28(1)"
      Tab(1).Control(32)=   "Label29(1)"
      Tab(1).Control(33)=   "LabSend(11)"
      Tab(1).Control(34)=   "Label24(11)"
      Tab(1).Control(35)=   "LabLoss(11)"
      Tab(1).Control(36)=   "LabRcv(11)"
      Tab(1).Control(37)=   "Label20(11)"
      Tab(1).Control(38)=   "LabSend(12)"
      Tab(1).Control(39)=   "Label24(12)"
      Tab(1).Control(40)=   "LabLoss(12)"
      Tab(1).Control(41)=   "LabRcv(12)"
      Tab(1).Control(42)=   "Label20(12)"
      Tab(1).Control(43)=   "LabSend(13)"
      Tab(1).Control(44)=   "Label24(13)"
      Tab(1).Control(45)=   "LabLoss(13)"
      Tab(1).Control(46)=   "LabRcv(13)"
      Tab(1).Control(47)=   "Label20(13)"
      Tab(1).Control(48)=   "LabSend(14)"
      Tab(1).Control(49)=   "Label24(14)"
      Tab(1).Control(50)=   "LabLoss(14)"
      Tab(1).Control(51)=   "LabRcv(14)"
      Tab(1).Control(52)=   "Label20(14)"
      Tab(1).Control(53)=   "LabSend(15)"
      Tab(1).Control(54)=   "Label24(15)"
      Tab(1).Control(55)=   "LabLoss(15)"
      Tab(1).Control(56)=   "LabRcv(15)"
      Tab(1).Control(57)=   "Label20(15)"
      Tab(1).Control(58)=   "TxtSendData(8)"
      Tab(1).Control(59)=   "Frame1(1)"
      Tab(1).Control(60)=   "TxtSendIntval(8)"
      Tab(1).Control(61)=   "TxtSendDataLen(8)"
      Tab(1).Control(62)=   "TxtSendData(9)"
      Tab(1).Control(63)=   "CmdSendBeg(8)"
      Tab(1).Control(64)=   "TxtCntSend(8)"
      Tab(1).Control(65)=   "TxtCntRcv(8)"
      Tab(1).Control(66)=   "TxtCntLoss(8)"
      Tab(1).Control(67)=   "TxtSendIntval(9)"
      Tab(1).Control(68)=   "TxtSendDataLen(9)"
      Tab(1).Control(69)=   "CmdSendBeg(9)"
      Tab(1).Control(70)=   "TxtCntLoss(9)"
      Tab(1).Control(71)=   "TxtCntRcv(9)"
      Tab(1).Control(72)=   "TxtCntSend(9)"
      Tab(1).Control(73)=   "TxtCntSendTal(8)"
      Tab(1).Control(74)=   "TxtCntSendTal(9)"
      Tab(1).Control(75)=   "TxtSendPketTal(8)"
      Tab(1).Control(76)=   "TxtSendPket(8)"
      Tab(1).Control(77)=   "TxtRcvPket(8)"
      Tab(1).Control(78)=   "TxtSendPketTal(9)"
      Tab(1).Control(79)=   "TxtSendPket(9)"
      Tab(1).Control(80)=   "TxtRcvPket(9)"
      Tab(1).Control(81)=   "TxtRcvPket(10)"
      Tab(1).Control(82)=   "TxtSendPket(10)"
      Tab(1).Control(83)=   "TxtSendPketTal(10)"
      Tab(1).Control(84)=   "TxtCntSendTal(10)"
      Tab(1).Control(85)=   "TxtCntSend(10)"
      Tab(1).Control(86)=   "TxtCntRcv(10)"
      Tab(1).Control(87)=   "TxtCntLoss(10)"
      Tab(1).Control(88)=   "CmdSendBeg(10)"
      Tab(1).Control(89)=   "TxtSendDataLen(10)"
      Tab(1).Control(90)=   "TxtSendIntval(10)"
      Tab(1).Control(91)=   "TxtSendData(10)"
      Tab(1).Control(92)=   "TxtSendData(11)"
      Tab(1).Control(93)=   "TxtSendIntval(11)"
      Tab(1).Control(94)=   "TxtSendDataLen(11)"
      Tab(1).Control(95)=   "CmdSendBeg(11)"
      Tab(1).Control(96)=   "TxtCntLoss(11)"
      Tab(1).Control(97)=   "TxtCntRcv(11)"
      Tab(1).Control(98)=   "TxtCntSend(11)"
      Tab(1).Control(99)=   "TxtCntSendTal(11)"
      Tab(1).Control(100)=   "TxtSendPketTal(11)"
      Tab(1).Control(101)=   "TxtSendPket(11)"
      Tab(1).Control(102)=   "TxtRcvPket(11)"
      Tab(1).Control(103)=   "TxtSendData(12)"
      Tab(1).Control(104)=   "TxtSendIntval(12)"
      Tab(1).Control(105)=   "TxtSendDataLen(12)"
      Tab(1).Control(106)=   "CmdSendBeg(12)"
      Tab(1).Control(107)=   "TxtCntLoss(12)"
      Tab(1).Control(108)=   "TxtCntRcv(12)"
      Tab(1).Control(109)=   "TxtCntSend(12)"
      Tab(1).Control(110)=   "TxtCntSendTal(12)"
      Tab(1).Control(111)=   "TxtSendPketTal(12)"
      Tab(1).Control(112)=   "TxtSendPket(12)"
      Tab(1).Control(113)=   "TxtRcvPket(12)"
      Tab(1).Control(114)=   "TxtSendData(13)"
      Tab(1).Control(115)=   "TxtSendIntval(13)"
      Tab(1).Control(116)=   "TxtSendDataLen(13)"
      Tab(1).Control(117)=   "CmdSendBeg(13)"
      Tab(1).Control(118)=   "TxtCntLoss(13)"
      Tab(1).Control(119)=   "TxtCntRcv(13)"
      Tab(1).Control(120)=   "TxtCntSend(13)"
      Tab(1).Control(121)=   "TxtCntSendTal(13)"
      Tab(1).Control(122)=   "TxtSendPketTal(13)"
      Tab(1).Control(123)=   "TxtSendPket(13)"
      Tab(1).Control(124)=   "TxtRcvPket(13)"
      Tab(1).Control(125)=   "TxtSendData(14)"
      Tab(1).Control(126)=   "TxtSendIntval(14)"
      Tab(1).Control(127)=   "TxtSendDataLen(14)"
      Tab(1).Control(128)=   "CmdSendBeg(14)"
      Tab(1).Control(129)=   "TxtCntLoss(14)"
      Tab(1).Control(130)=   "TxtCntRcv(14)"
      Tab(1).Control(131)=   "TxtCntSend(14)"
      Tab(1).Control(132)=   "TxtCntSendTal(14)"
      Tab(1).Control(133)=   "TxtSendPketTal(14)"
      Tab(1).Control(134)=   "TxtSendPket(14)"
      Tab(1).Control(135)=   "TxtRcvPket(14)"
      Tab(1).Control(136)=   "TxtSendData(15)"
      Tab(1).Control(137)=   "TxtSendIntval(15)"
      Tab(1).Control(138)=   "TxtSendDataLen(15)"
      Tab(1).Control(139)=   "CmdSendBeg(15)"
      Tab(1).Control(140)=   "TxtCntLoss(15)"
      Tab(1).Control(141)=   "TxtCntRcv(15)"
      Tab(1).Control(142)=   "TxtCntSend(15)"
      Tab(1).Control(143)=   "TxtCntSendTal(15)"
      Tab(1).Control(144)=   "TxtSendPketTal(15)"
      Tab(1).Control(145)=   "TxtSendPket(15)"
      Tab(1).Control(146)=   "TxtRcvPket(15)"
      Tab(1).Control(147)=   "TmrSend(8)"
      Tab(1).Control(148)=   "TmrSend(9)"
      Tab(1).Control(149)=   "TmrSend(10)"
      Tab(1).Control(150)=   "TmrSend(11)"
      Tab(1).Control(151)=   "TmrSend(12)"
      Tab(1).Control(152)=   "TmrSend(13)"
      Tab(1).Control(153)=   "TmrSend(14)"
      Tab(1).Control(154)=   "TmrSend(15)"
      Tab(1).Control(155)=   "CmdClrCnt(8)"
      Tab(1).Control(156)=   "CmdClrCnt(9)"
      Tab(1).Control(157)=   "CmdClrCnt(10)"
      Tab(1).Control(158)=   "CmdClrCnt(11)"
      Tab(1).Control(159)=   "CmdClrCnt(12)"
      Tab(1).Control(160)=   "CmdClrCnt(13)"
      Tab(1).Control(161)=   "CmdClrCnt(14)"
      Tab(1).Control(162)=   "CmdClrCnt(15)"
      Tab(1).ControlCount=   163
      TabCaption(2)   =   "Tab 2"
      TabPicture(2)   =   "TCP.frx":047A
      Tab(2).ControlEnabled=   0   'False
      Tab(2).Control(0)=   "Label20(20)"
      Tab(2).Control(1)=   "LabRcv(20)"
      Tab(2).Control(2)=   "LabLoss(20)"
      Tab(2).Control(3)=   "Label24(20)"
      Tab(2).Control(4)=   "LabSend(20)"
      Tab(2).Control(5)=   "Label29(2)"
      Tab(2).Control(6)=   "Label28(2)"
      Tab(2).Control(7)=   "Label27(2)"
      Tab(2).Control(8)=   "Label26(2)"
      Tab(2).Control(9)=   "Label25(2)"
      Tab(2).Control(10)=   "Label23(2)"
      Tab(2).Control(11)=   "Label19(2)"
      Tab(2).Control(12)=   "LabSend(22)"
      Tab(2).Control(13)=   "Label20(22)"
      Tab(2).Control(14)=   "LabRcv(22)"
      Tab(2).Control(15)=   "LabLoss(22)"
      Tab(2).Control(16)=   "Label24(22)"
      Tab(2).Control(17)=   "LabLoss(23)"
      Tab(2).Control(18)=   "LabRcv(23)"
      Tab(2).Control(19)=   "Label20(23)"
      Tab(2).Control(20)=   "LabSend(23)"
      Tab(2).Control(21)=   "Label17(2)"
      Tab(2).Control(22)=   "Label16(2)"
      Tab(2).Control(23)=   "Label15(2)"
      Tab(2).Control(24)=   "Label12(2)"
      Tab(2).Control(25)=   "Label5(2)"
      Tab(2).Control(26)=   "Label8(2)"
      Tab(2).Control(27)=   "Label22(7)"
      Tab(2).Control(28)=   "Label24(23)"
      Tab(2).Control(29)=   "Label22(8)"
      Tab(2).Control(30)=   "LabRcv(16)"
      Tab(2).Control(31)=   "LabLoss(16)"
      Tab(2).Control(32)=   "Label24(16)"
      Tab(2).Control(33)=   "LabSend(16)"
      Tab(2).Control(34)=   "Label20(16)"
      Tab(2).Control(35)=   "LabSend(17)"
      Tab(2).Control(36)=   "Label24(17)"
      Tab(2).Control(37)=   "LabLoss(17)"
      Tab(2).Control(38)=   "LabRcv(17)"
      Tab(2).Control(39)=   "Label20(17)"
      Tab(2).Control(40)=   "LabSend(19)"
      Tab(2).Control(41)=   "Label24(19)"
      Tab(2).Control(42)=   "LabLoss(19)"
      Tab(2).Control(43)=   "LabRcv(19)"
      Tab(2).Control(44)=   "Label20(19)"
      Tab(2).Control(45)=   "Label2(2)"
      Tab(2).Control(46)=   "Label4(2)"
      Tab(2).Control(47)=   "LabSend(18)"
      Tab(2).Control(48)=   "Label24(18)"
      Tab(2).Control(49)=   "LabLoss(18)"
      Tab(2).Control(50)=   "LabRcv(18)"
      Tab(2).Control(51)=   "Label20(18)"
      Tab(2).Control(52)=   "Label20(21)"
      Tab(2).Control(53)=   "LabRcv(21)"
      Tab(2).Control(54)=   "Label22(6)"
      Tab(2).Control(55)=   "LabLoss(21)"
      Tab(2).Control(56)=   "Label24(21)"
      Tab(2).Control(57)=   "LabSend(21)"
      Tab(2).Control(58)=   "CmdClrCnt(20)"
      Tab(2).Control(59)=   "CmdClrCnt(22)"
      Tab(2).Control(60)=   "CmdClrCnt(23)"
      Tab(2).Control(61)=   "TmrSend(20)"
      Tab(2).Control(62)=   "TmrSend(22)"
      Tab(2).Control(63)=   "TmrSend(23)"
      Tab(2).Control(64)=   "TxtSendData(16)"
      Tab(2).Control(65)=   "TxtRcvPket(20)"
      Tab(2).Control(66)=   "TxtSendPket(20)"
      Tab(2).Control(67)=   "TxtSendPketTal(20)"
      Tab(2).Control(68)=   "TxtCntSendTal(20)"
      Tab(2).Control(69)=   "TxtCntSend(20)"
      Tab(2).Control(70)=   "TxtCntRcv(20)"
      Tab(2).Control(71)=   "TxtCntLoss(20)"
      Tab(2).Control(72)=   "CmdSendBeg(20)"
      Tab(2).Control(73)=   "TxtSendDataLen(20)"
      Tab(2).Control(74)=   "TxtSendIntval(20)"
      Tab(2).Control(75)=   "TxtSendData(20)"
      Tab(2).Control(76)=   "TxtRcvPket(22)"
      Tab(2).Control(77)=   "TxtSendPket(22)"
      Tab(2).Control(78)=   "TxtSendPketTal(22)"
      Tab(2).Control(79)=   "TxtRcvPket(23)"
      Tab(2).Control(80)=   "TxtSendPket(23)"
      Tab(2).Control(81)=   "TxtSendPketTal(23)"
      Tab(2).Control(82)=   "TxtCntSendTal(22)"
      Tab(2).Control(83)=   "TxtCntSendTal(23)"
      Tab(2).Control(84)=   "TxtCntSend(22)"
      Tab(2).Control(85)=   "TxtCntRcv(22)"
      Tab(2).Control(86)=   "TxtCntLoss(22)"
      Tab(2).Control(87)=   "CmdSendBeg(22)"
      Tab(2).Control(88)=   "TxtSendDataLen(22)"
      Tab(2).Control(89)=   "TxtSendIntval(22)"
      Tab(2).Control(90)=   "TxtCntLoss(23)"
      Tab(2).Control(91)=   "TxtCntRcv(23)"
      Tab(2).Control(92)=   "TxtCntSend(23)"
      Tab(2).Control(93)=   "CmdSendBeg(23)"
      Tab(2).Control(94)=   "TxtSendData(22)"
      Tab(2).Control(95)=   "TxtSendDataLen(23)"
      Tab(2).Control(96)=   "TxtSendIntval(23)"
      Tab(2).Control(97)=   "Frame1(2)"
      Tab(2).Control(98)=   "TxtSendData(23)"
      Tab(2).Control(99)=   "CmdClrCnt(16)"
      Tab(2).Control(100)=   "TmrSend(16)"
      Tab(2).Control(101)=   "TxtRcvPket(16)"
      Tab(2).Control(102)=   "TxtSendPket(16)"
      Tab(2).Control(103)=   "TxtSendPketTal(16)"
      Tab(2).Control(104)=   "TxtCntSendTal(16)"
      Tab(2).Control(105)=   "TxtCntSend(16)"
      Tab(2).Control(106)=   "TxtCntRcv(16)"
      Tab(2).Control(107)=   "TxtCntLoss(16)"
      Tab(2).Control(108)=   "CmdSendBeg(16)"
      Tab(2).Control(109)=   "TxtSendDataLen(16)"
      Tab(2).Control(110)=   "TxtSendIntval(16)"
      Tab(2).Control(111)=   "TxtSendData(17)"
      Tab(2).Control(112)=   "TxtSendIntval(17)"
      Tab(2).Control(113)=   "TxtSendDataLen(17)"
      Tab(2).Control(114)=   "CmdSendBeg(17)"
      Tab(2).Control(115)=   "TxtCntLoss(17)"
      Tab(2).Control(116)=   "TxtCntRcv(17)"
      Tab(2).Control(117)=   "TxtCntSend(17)"
      Tab(2).Control(118)=   "TxtCntSendTal(17)"
      Tab(2).Control(119)=   "TxtSendPketTal(17)"
      Tab(2).Control(120)=   "TxtSendPket(17)"
      Tab(2).Control(121)=   "TxtRcvPket(17)"
      Tab(2).Control(122)=   "TmrSend(17)"
      Tab(2).Control(123)=   "CmdClrCnt(17)"
      Tab(2).Control(124)=   "TxtSendData(19)"
      Tab(2).Control(125)=   "TxtSendIntval(19)"
      Tab(2).Control(126)=   "TxtSendDataLen(19)"
      Tab(2).Control(127)=   "CmdSendBeg(19)"
      Tab(2).Control(128)=   "TxtCntLoss(19)"
      Tab(2).Control(129)=   "TxtCntRcv(19)"
      Tab(2).Control(130)=   "TxtCntSend(19)"
      Tab(2).Control(131)=   "TxtCntSendTal(19)"
      Tab(2).Control(132)=   "TxtSendPketTal(19)"
      Tab(2).Control(133)=   "TxtSendPket(19)"
      Tab(2).Control(134)=   "TxtRcvPket(19)"
      Tab(2).Control(135)=   "TmrSend(19)"
      Tab(2).Control(136)=   "CmdClrCnt(19)"
      Tab(2).Control(137)=   "TxtSendData(18)"
      Tab(2).Control(138)=   "TxtSendIntval(18)"
      Tab(2).Control(139)=   "TxtSendDataLen(18)"
      Tab(2).Control(140)=   "CmdSendBeg(18)"
      Tab(2).Control(141)=   "TxtCntLoss(18)"
      Tab(2).Control(142)=   "TxtCntRcv(18)"
      Tab(2).Control(143)=   "TxtCntSend(18)"
      Tab(2).Control(144)=   "TxtCntSendTal(18)"
      Tab(2).Control(145)=   "TxtSendPketTal(18)"
      Tab(2).Control(146)=   "TxtSendPket(18)"
      Tab(2).Control(147)=   "TxtRcvPket(18)"
      Tab(2).Control(148)=   "TmrSend(18)"
      Tab(2).Control(149)=   "CmdClrCnt(18)"
      Tab(2).Control(150)=   "TxtRcvPket(21)"
      Tab(2).Control(151)=   "TxtSendPket(21)"
      Tab(2).Control(152)=   "TxtSendPketTal(21)"
      Tab(2).Control(153)=   "TxtCntSendTal(21)"
      Tab(2).Control(154)=   "TxtCntSend(21)"
      Tab(2).Control(155)=   "TxtCntRcv(21)"
      Tab(2).Control(156)=   "TxtCntLoss(21)"
      Tab(2).Control(157)=   "CmdSendBeg(21)"
      Tab(2).Control(158)=   "TxtSendDataLen(21)"
      Tab(2).Control(159)=   "TxtSendIntval(21)"
      Tab(2).Control(160)=   "TxtSendData(21)"
      Tab(2).Control(161)=   "TmrSend(21)"
      Tab(2).Control(162)=   "CmdClrCnt(21)"
      Tab(2).ControlCount=   163
      TabCaption(3)   =   "Tab 3"
      TabPicture(3)   =   "TCP.frx":0496
      Tab(3).ControlEnabled=   0   'False
      Tab(3).Control(0)=   "CmdClrCnt(27)"
      Tab(3).Control(1)=   "TmrSend(27)"
      Tab(3).Control(2)=   "TxtRcvPket(27)"
      Tab(3).Control(3)=   "TxtSendPket(27)"
      Tab(3).Control(4)=   "TxtSendPketTal(27)"
      Tab(3).Control(5)=   "TxtCntSendTal(27)"
      Tab(3).Control(6)=   "TxtCntSend(27)"
      Tab(3).Control(7)=   "TxtCntRcv(27)"
      Tab(3).Control(8)=   "TxtCntLoss(27)"
      Tab(3).Control(9)=   "CmdSendBeg(27)"
      Tab(3).Control(10)=   "TxtSendDataLen(27)"
      Tab(3).Control(11)=   "TxtSendIntval(27)"
      Tab(3).Control(12)=   "TxtSendData(27)"
      Tab(3).Control(13)=   "CmdClrCnt(26)"
      Tab(3).Control(14)=   "TmrSend(26)"
      Tab(3).Control(15)=   "TxtRcvPket(26)"
      Tab(3).Control(16)=   "TxtSendPket(26)"
      Tab(3).Control(17)=   "TxtSendPketTal(26)"
      Tab(3).Control(18)=   "TxtCntSendTal(26)"
      Tab(3).Control(19)=   "TxtCntSend(26)"
      Tab(3).Control(20)=   "TxtCntRcv(26)"
      Tab(3).Control(21)=   "TxtCntLoss(26)"
      Tab(3).Control(22)=   "CmdSendBeg(26)"
      Tab(3).Control(23)=   "TxtSendDataLen(26)"
      Tab(3).Control(24)=   "TxtSendIntval(26)"
      Tab(3).Control(25)=   "TxtSendData(26)"
      Tab(3).Control(26)=   "CmdClrCnt(25)"
      Tab(3).Control(27)=   "TmrSend(25)"
      Tab(3).Control(28)=   "TxtRcvPket(25)"
      Tab(3).Control(29)=   "TxtSendPket(25)"
      Tab(3).Control(30)=   "TxtSendPketTal(25)"
      Tab(3).Control(31)=   "TxtCntSendTal(25)"
      Tab(3).Control(32)=   "TxtCntSend(25)"
      Tab(3).Control(33)=   "TxtCntRcv(25)"
      Tab(3).Control(34)=   "TxtCntLoss(25)"
      Tab(3).Control(35)=   "CmdSendBeg(25)"
      Tab(3).Control(36)=   "TxtSendDataLen(25)"
      Tab(3).Control(37)=   "TxtSendIntval(25)"
      Tab(3).Control(38)=   "TxtSendData(25)"
      Tab(3).Control(39)=   "TxtSendIntval(31)"
      Tab(3).Control(40)=   "TxtSendDataLen(31)"
      Tab(3).Control(41)=   "TxtSendData(30)"
      Tab(3).Control(42)=   "CmdSendBeg(31)"
      Tab(3).Control(43)=   "TxtCntSend(31)"
      Tab(3).Control(44)=   "TxtCntRcv(31)"
      Tab(3).Control(45)=   "TxtCntLoss(31)"
      Tab(3).Control(46)=   "TxtSendPketTal(31)"
      Tab(3).Control(47)=   "TxtSendPket(31)"
      Tab(3).Control(48)=   "TxtRcvPket(31)"
      Tab(3).Control(49)=   "TmrSend(31)"
      Tab(3).Control(50)=   "CmdClrCnt(31)"
      Tab(3).Control(51)=   "TxtCntSendTal(30)"
      Tab(3).Control(52)=   "TxtSendData(31)"
      Tab(3).Control(53)=   "Frame1(3)"
      Tab(3).Control(54)=   "TxtSendIntval(30)"
      Tab(3).Control(55)=   "TxtSendDataLen(30)"
      Tab(3).Control(56)=   "CmdSendBeg(30)"
      Tab(3).Control(57)=   "TxtCntLoss(30)"
      Tab(3).Control(58)=   "TxtCntRcv(30)"
      Tab(3).Control(59)=   "TxtCntSend(30)"
      Tab(3).Control(60)=   "TxtCntSendTal(31)"
      Tab(3).Control(61)=   "TxtSendPketTal(30)"
      Tab(3).Control(62)=   "TxtSendPket(30)"
      Tab(3).Control(63)=   "TxtRcvPket(30)"
      Tab(3).Control(64)=   "TxtRcvPket(29)"
      Tab(3).Control(65)=   "TxtSendPket(29)"
      Tab(3).Control(66)=   "TxtSendPketTal(29)"
      Tab(3).Control(67)=   "TxtCntSendTal(29)"
      Tab(3).Control(68)=   "TxtCntSend(29)"
      Tab(3).Control(69)=   "TxtCntRcv(29)"
      Tab(3).Control(70)=   "TxtCntLoss(29)"
      Tab(3).Control(71)=   "CmdSendBeg(29)"
      Tab(3).Control(72)=   "TxtSendDataLen(29)"
      Tab(3).Control(73)=   "TxtSendIntval(29)"
      Tab(3).Control(74)=   "TxtSendData(29)"
      Tab(3).Control(75)=   "TxtSendData(28)"
      Tab(3).Control(76)=   "TxtSendIntval(28)"
      Tab(3).Control(77)=   "TxtSendDataLen(28)"
      Tab(3).Control(78)=   "CmdSendBeg(28)"
      Tab(3).Control(79)=   "TxtCntLoss(28)"
      Tab(3).Control(80)=   "TxtCntRcv(28)"
      Tab(3).Control(81)=   "TxtCntSend(28)"
      Tab(3).Control(82)=   "TxtCntSendTal(28)"
      Tab(3).Control(83)=   "TxtSendPketTal(28)"
      Tab(3).Control(84)=   "TxtSendPket(28)"
      Tab(3).Control(85)=   "TxtRcvPket(28)"
      Tab(3).Control(86)=   "TxtSendData(24)"
      Tab(3).Control(87)=   "TxtSendIntval(24)"
      Tab(3).Control(88)=   "TxtSendDataLen(24)"
      Tab(3).Control(89)=   "CmdSendBeg(24)"
      Tab(3).Control(90)=   "TxtCntLoss(24)"
      Tab(3).Control(91)=   "TxtCntRcv(24)"
      Tab(3).Control(92)=   "TxtCntSend(24)"
      Tab(3).Control(93)=   "TxtCntSendTal(24)"
      Tab(3).Control(94)=   "TxtSendPketTal(24)"
      Tab(3).Control(95)=   "TxtSendPket(24)"
      Tab(3).Control(96)=   "TxtRcvPket(24)"
      Tab(3).Control(97)=   "TmrSend(30)"
      Tab(3).Control(98)=   "TmrSend(29)"
      Tab(3).Control(99)=   "TmrSend(28)"
      Tab(3).Control(100)=   "TmrSend(24)"
      Tab(3).Control(101)=   "CmdClrCnt(30)"
      Tab(3).Control(102)=   "CmdClrCnt(29)"
      Tab(3).Control(103)=   "CmdClrCnt(28)"
      Tab(3).Control(104)=   "CmdClrCnt(24)"
      Tab(3).Control(105)=   "Label20(27)"
      Tab(3).Control(106)=   "LabRcv(27)"
      Tab(3).Control(107)=   "LabLoss(27)"
      Tab(3).Control(108)=   "Label24(27)"
      Tab(3).Control(109)=   "LabSend(27)"
      Tab(3).Control(110)=   "Label20(26)"
      Tab(3).Control(111)=   "LabRcv(26)"
      Tab(3).Control(112)=   "LabLoss(26)"
      Tab(3).Control(113)=   "Label24(26)"
      Tab(3).Control(114)=   "LabSend(26)"
      Tab(3).Control(115)=   "Label4(3)"
      Tab(3).Control(116)=   "Label2(3)"
      Tab(3).Control(117)=   "Label20(25)"
      Tab(3).Control(118)=   "LabRcv(25)"
      Tab(3).Control(119)=   "LabLoss(25)"
      Tab(3).Control(120)=   "Label24(25)"
      Tab(3).Control(121)=   "LabSend(25)"
      Tab(3).Control(122)=   "Label24(31)"
      Tab(3).Control(123)=   "LabSend(31)"
      Tab(3).Control(124)=   "Label20(31)"
      Tab(3).Control(125)=   "LabRcv(31)"
      Tab(3).Control(126)=   "LabLoss(31)"
      Tab(3).Control(127)=   "Label22(11)"
      Tab(3).Control(128)=   "Label22(10)"
      Tab(3).Control(129)=   "Label8(3)"
      Tab(3).Control(130)=   "Label5(3)"
      Tab(3).Control(131)=   "Label12(3)"
      Tab(3).Control(132)=   "Label15(3)"
      Tab(3).Control(133)=   "Label16(3)"
      Tab(3).Control(134)=   "Label17(3)"
      Tab(3).Control(135)=   "Label24(30)"
      Tab(3).Control(136)=   "LabLoss(30)"
      Tab(3).Control(137)=   "LabRcv(30)"
      Tab(3).Control(138)=   "Label20(30)"
      Tab(3).Control(139)=   "LabSend(30)"
      Tab(3).Control(140)=   "Label19(3)"
      Tab(3).Control(141)=   "Label20(29)"
      Tab(3).Control(142)=   "LabRcv(29)"
      Tab(3).Control(143)=   "Label22(9)"
      Tab(3).Control(144)=   "LabLoss(29)"
      Tab(3).Control(145)=   "Label24(29)"
      Tab(3).Control(146)=   "LabSend(29)"
      Tab(3).Control(147)=   "Label23(3)"
      Tab(3).Control(148)=   "Label25(3)"
      Tab(3).Control(149)=   "Label26(3)"
      Tab(3).Control(150)=   "Label27(3)"
      Tab(3).Control(151)=   "Label28(3)"
      Tab(3).Control(152)=   "Label29(3)"
      Tab(3).Control(153)=   "LabSend(28)"
      Tab(3).Control(154)=   "Label24(28)"
      Tab(3).Control(155)=   "LabLoss(28)"
      Tab(3).Control(156)=   "LabRcv(28)"
      Tab(3).Control(157)=   "Label20(28)"
      Tab(3).Control(158)=   "LabSend(24)"
      Tab(3).Control(159)=   "Label24(24)"
      Tab(3).Control(160)=   "LabLoss(24)"
      Tab(3).Control(161)=   "LabRcv(24)"
      Tab(3).Control(162)=   "Label20(24)"
      Tab(3).ControlCount=   163
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   27
         Left            =   -68520
         TabIndex        =   836
         Top             =   5880
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Timer TmrSend 
         Index           =   27
         Left            =   -69000
         Top             =   5880
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   27
         Left            =   -68280
         TabIndex        =   835
         Text            =   "0"
         Top             =   7320
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   27
         Left            =   -68280
         TabIndex        =   834
         Text            =   "0"
         Top             =   6840
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   27
         Left            =   -68280
         TabIndex        =   833
         Text            =   "0"
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   27
         Left            =   -70320
         TabIndex        =   832
         Text            =   "0"
         Top             =   6360
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   27
         Left            =   -70320
         TabIndex        =   831
         Text            =   "0"
         Top             =   6840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   27
         Left            =   -70320
         TabIndex        =   830
         Text            =   "0"
         Top             =   7320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   27
         Left            =   -70320
         TabIndex        =   829
         Text            =   "0"
         Top             =   7800
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM28"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   27
         Left            =   -70320
         Style           =   1  '圖片外觀
         TabIndex        =   828
         Top             =   5880
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   27
         Left            =   -69120
         TabIndex        =   827
         Text            =   "10"
         Top             =   5520
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   27
         Left            =   -69120
         TabIndex        =   826
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5160
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   27
         Left            =   -70320
         TabIndex        =   825
         Top             =   8160
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   26
         Left            =   -68520
         TabIndex        =   817
         Top             =   2460
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Timer TmrSend 
         Index           =   26
         Left            =   -69000
         Top             =   2460
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   26
         Left            =   -68280
         TabIndex        =   816
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   26
         Left            =   -68280
         TabIndex        =   815
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   26
         Left            =   -68280
         TabIndex        =   814
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   26
         Left            =   -70320
         TabIndex        =   813
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   26
         Left            =   -70320
         TabIndex        =   812
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   26
         Left            =   -70320
         TabIndex        =   811
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   26
         Left            =   -70320
         TabIndex        =   810
         Text            =   "0"
         Top             =   4320
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM27"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   26
         Left            =   -70320
         Style           =   1  '圖片外觀
         TabIndex        =   809
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   26
         Left            =   -69120
         TabIndex        =   808
         Text            =   "10"
         Top             =   2040
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   26
         Left            =   -69120
         TabIndex        =   807
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   26
         Left            =   -70320
         TabIndex        =   806
         Top             =   4680
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   25
         Left            =   -73080
         TabIndex        =   800
         Top             =   5880
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Timer TmrSend 
         Index           =   25
         Left            =   -73560
         Top             =   5880
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   25
         Left            =   -71400
         TabIndex        =   799
         Text            =   "0"
         Top             =   7320
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   25
         Left            =   -71400
         TabIndex        =   798
         Text            =   "0"
         Top             =   6840
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   25
         Left            =   -71400
         TabIndex        =   797
         Text            =   "0"
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   25
         Left            =   -73440
         TabIndex        =   796
         Text            =   "0"
         Top             =   6360
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   25
         Left            =   -73440
         TabIndex        =   795
         Text            =   "0"
         Top             =   6840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   25
         Left            =   -73440
         TabIndex        =   794
         Text            =   "0"
         Top             =   7320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   25
         Left            =   -73440
         TabIndex        =   793
         Text            =   "0"
         Top             =   7800
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         Appearance      =   0  '平面
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM26"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   25
         Left            =   -74880
         Style           =   1  '圖片外觀
         TabIndex        =   792
         Top             =   5880
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   25
         Left            =   -72240
         TabIndex        =   791
         Text            =   "10"
         Top             =   5520
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   25
         Left            =   -72240
         TabIndex        =   790
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5160
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   25
         Left            =   -73440
         TabIndex        =   789
         Top             =   8160
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   31
         Left            =   -62880
         TabIndex        =   783
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5160
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   31
         Left            =   -62880
         TabIndex        =   782
         Text            =   "10"
         Top             =   5520
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Index           =   30
         Left            =   -64080
         TabIndex        =   781
         Top             =   8160
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.CommandButton CmdSendBeg 
         Appearance      =   0  '平面
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM32"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   31
         Left            =   -64080
         Style           =   1  '圖片外觀
         TabIndex        =   780
         Top             =   5880
         Width           =   1215
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   31
         Left            =   -64080
         TabIndex        =   779
         Text            =   "0"
         Top             =   6840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   31
         Left            =   -64080
         TabIndex        =   778
         Text            =   "0"
         Top             =   7320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   31
         Left            =   -64080
         TabIndex        =   777
         Text            =   "0"
         Top             =   7800
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   31
         Left            =   -62040
         TabIndex        =   776
         Text            =   "0"
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   31
         Left            =   -62040
         TabIndex        =   775
         Text            =   "0"
         Top             =   6840
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   31
         Left            =   -62040
         TabIndex        =   774
         Text            =   "0"
         Top             =   7320
         Width           =   855
      End
      Begin VB.Timer TmrSend 
         Index           =   31
         Left            =   -62760
         Top             =   5880
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   31
         Left            =   -62280
         TabIndex        =   773
         Top             =   5880
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   30
         Left            =   -64080
         TabIndex        =   772
         Text            =   "0"
         Top             =   6360
         Width           =   1095
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   31
         Left            =   -64080
         TabIndex        =   723
         Top             =   4680
         Visible         =   0   'False
         Width           =   3015
      End
      Begin VB.Frame Frame1 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1215
         Index           =   3
         Left            =   -74880
         TabIndex        =   689
         Top             =   360
         Width           =   14055
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   28
            Left            =   8400
            TabIndex        =   771
            Text            =   "4663"
            Top             =   240
            Width           =   495
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   28
            Left            =   9000
            Style           =   1  '圖片外觀
            TabIndex        =   770
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   28
            Left            =   7320
            TabIndex        =   769
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   26
            Left            =   4920
            TabIndex        =   768
            Text            =   "4665"
            Top             =   240
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   26
            Left            =   5640
            Style           =   1  '圖片外觀
            TabIndex        =   767
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   26
            Left            =   3840
            TabIndex        =   766
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   30
            Left            =   11760
            TabIndex        =   765
            Text            =   "4660"
            Top             =   240
            Width           =   495
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   30
            Left            =   10680
            TabIndex        =   764
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   30
            Left            =   12360
            Style           =   1  '圖片外觀
            TabIndex        =   763
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   24
            Left            =   1440
            TabIndex        =   762
            Text            =   "4667"
            Top             =   240
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   24
            Left            =   2160
            Style           =   1  '圖片外觀
            TabIndex        =   761
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   24
            Left            =   360
            TabIndex        =   760
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   31
            Left            =   13440
            TabIndex        =   697
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   30
            Left            =   13440
            TabIndex        =   696
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   29
            Left            =   10080
            TabIndex        =   695
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   28
            Left            =   10080
            TabIndex        =   694
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   27
            Left            =   6720
            TabIndex        =   693
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   26
            Left            =   6720
            TabIndex        =   692
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   25
            Left            =   3240
            TabIndex        =   691
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   24
            Left            =   3240
            TabIndex        =   690
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   31
            Left            =   11760
            TabIndex        =   713
            Text            =   "4661"
            Top             =   720
            Width           =   495
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   31
            Left            =   10680
            TabIndex        =   712
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   31
            Left            =   12360
            Style           =   1  '圖片外觀
            TabIndex        =   711
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtStatus2425 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   3360
            MultiLine       =   -1  'True
            TabIndex        =   710
            Top             =   360
            Width           =   375
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   29
            Left            =   9000
            Style           =   1  '圖片外觀
            TabIndex        =   709
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   29
            Left            =   8400
            TabIndex        =   708
            Text            =   "4662"
            Top             =   720
            Width           =   495
         End
         Begin VB.TextBox txtStatus2627 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   6840
            MultiLine       =   -1  'True
            TabIndex        =   707
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   27
            Left            =   4920
            TabIndex        =   706
            Text            =   "4664"
            Top             =   720
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   27
            Left            =   5640
            Style           =   1  '圖片外觀
            TabIndex        =   705
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtStatus2829 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   10200
            MultiLine       =   -1  'True
            TabIndex        =   704
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   25
            Left            =   1440
            TabIndex        =   703
            Text            =   "4666"
            Top             =   720
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   25
            Left            =   2160
            Style           =   1  '圖片外觀
            TabIndex        =   702
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtStatus3031 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   13560
            MultiLine       =   -1  'True
            TabIndex        =   701
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   29
            Left            =   7320
            TabIndex        =   700
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   27
            Left            =   3840
            TabIndex        =   699
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   25
            Left            =   360
            TabIndex        =   698
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   24
            Left            =   960
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   25
            Left            =   480
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   26
            Left            =   3960
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   27
            Left            =   4440
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   28
            Left            =   7920
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   29
            Left            =   8400
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   30
            Left            =   11040
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   31
            Left            =   11520
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin VB.Label Label45 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   13440
            TabIndex        =   722
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label1 
            Caption         =   "Receive From GW 2 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   7
            Left            =   120
            TabIndex        =   721
            Top             =   720
            Visible         =   0   'False
            Width           =   135
         End
         Begin VB.Label Label1 
            Caption         =   "Send To GW 1 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   6
            Left            =   120
            TabIndex        =   720
            Top             =   360
            Visible         =   0   'False
            Width           =   135
         End
         Begin VB.Label LabLoop 
            Caption         =   "IP:"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   255
            Index           =   11
            Left            =   120
            TabIndex        =   719
            Top             =   240
            Width           =   255
         End
         Begin VB.Label LabLoop 
            Caption         =   "GW 2 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   10
            Left            =   360
            TabIndex        =   718
            Top             =   720
            Visible         =   0   'False
            Width           =   855
         End
         Begin VB.Label LabLoop 
            Caption         =   "IP"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   9
            Left            =   4680
            TabIndex        =   717
            Top             =   600
            Visible         =   0   'False
            Width           =   735
         End
         Begin VB.Label Label44 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   10080
            TabIndex        =   716
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label43 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   6720
            TabIndex        =   715
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label42 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   3240
            TabIndex        =   714
            Top             =   120
            Width           =   540
         End
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   30
         Left            =   -62880
         TabIndex        =   688
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   30
         Left            =   -62880
         TabIndex        =   687
         Text            =   "10"
         Top             =   2040
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM31"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   30
         Left            =   -64080
         Style           =   1  '圖片外觀
         TabIndex        =   686
         Top             =   2400
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   30
         Left            =   -64080
         TabIndex        =   685
         Text            =   "0"
         Top             =   4320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   30
         Left            =   -64080
         TabIndex        =   684
         Text            =   "0"
         Top             =   3840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   30
         Left            =   -64080
         TabIndex        =   683
         Text            =   "0"
         Top             =   3360
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   31
         Left            =   -64080
         TabIndex        =   682
         Text            =   "0"
         Top             =   2880
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   30
         Left            =   -62040
         TabIndex        =   681
         Text            =   "0"
         Top             =   2880
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   30
         Left            =   -62040
         TabIndex        =   680
         Text            =   "0"
         Top             =   3360
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   30
         Left            =   -62040
         TabIndex        =   679
         Text            =   "0"
         Top             =   3840
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   29
         Left            =   -65160
         TabIndex        =   678
         Text            =   "0"
         Top             =   7320
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   29
         Left            =   -65160
         TabIndex        =   677
         Text            =   "0"
         Top             =   6840
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   29
         Left            =   -65160
         TabIndex        =   676
         Text            =   "0"
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   29
         Left            =   -67200
         TabIndex        =   675
         Text            =   "0"
         Top             =   6360
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   29
         Left            =   -67200
         TabIndex        =   674
         Text            =   "0"
         Top             =   6840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   29
         Left            =   -67200
         TabIndex        =   673
         Text            =   "0"
         Top             =   7320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   29
         Left            =   -67200
         TabIndex        =   672
         Text            =   "0"
         Top             =   7800
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM30"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   29
         Left            =   -67200
         Style           =   1  '圖片外觀
         TabIndex        =   671
         Top             =   5880
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   29
         Left            =   -66000
         TabIndex        =   670
         Text            =   "10"
         Top             =   5520
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   29
         Left            =   -66000
         TabIndex        =   669
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5160
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   29
         Left            =   -67200
         TabIndex        =   668
         Top             =   8160
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   28
         Left            =   -67200
         TabIndex        =   667
         Top             =   4680
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   28
         Left            =   -66000
         TabIndex        =   666
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   28
         Left            =   -66000
         TabIndex        =   665
         Text            =   "10"
         Top             =   2040
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM29"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   28
         Left            =   -67200
         Style           =   1  '圖片外觀
         TabIndex        =   664
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   28
         Left            =   -67200
         TabIndex        =   663
         Text            =   "0"
         Top             =   4320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   28
         Left            =   -67200
         TabIndex        =   662
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   28
         Left            =   -67200
         TabIndex        =   661
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   28
         Left            =   -67200
         TabIndex        =   660
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   28
         Left            =   -65160
         TabIndex        =   659
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   28
         Left            =   -65160
         TabIndex        =   658
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   28
         Left            =   -65160
         TabIndex        =   657
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   24
         Left            =   -73440
         TabIndex        =   656
         Top             =   4680
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   24
         Left            =   -72240
         TabIndex        =   655
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   24
         Left            =   -72240
         TabIndex        =   654
         Text            =   "10"
         Top             =   2040
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM25"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   24
         Left            =   -74880
         Style           =   1  '圖片外觀
         TabIndex        =   653
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   24
         Left            =   -73440
         TabIndex        =   652
         Text            =   "0"
         Top             =   4320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   24
         Left            =   -73440
         TabIndex        =   651
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   24
         Left            =   -73440
         TabIndex        =   650
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   24
         Left            =   -73440
         TabIndex        =   649
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   24
         Left            =   -71400
         TabIndex        =   648
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   24
         Left            =   -71400
         TabIndex        =   647
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   24
         Left            =   -71400
         TabIndex        =   646
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.Timer TmrSend 
         Index           =   30
         Left            =   -62760
         Top             =   2340
      End
      Begin VB.Timer TmrSend 
         Index           =   29
         Left            =   -65880
         Top             =   5880
      End
      Begin VB.Timer TmrSend 
         Index           =   28
         Left            =   -65880
         Top             =   2460
      End
      Begin VB.Timer TmrSend 
         Index           =   24
         Left            =   -73560
         Top             =   2460
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   30
         Left            =   -62280
         TabIndex        =   645
         Top             =   2340
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   29
         Left            =   -65400
         TabIndex        =   644
         Top             =   5880
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   28
         Left            =   -65400
         TabIndex        =   643
         Top             =   2460
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   24
         Left            =   -73080
         TabIndex        =   642
         Top             =   2460
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   21
         Left            =   -65400
         TabIndex        =   635
         Top             =   5880
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Timer TmrSend 
         Index           =   21
         Left            =   -65880
         Top             =   5880
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   21
         Left            =   -67200
         TabIndex        =   634
         Top             =   8160
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   21
         Left            =   -66000
         TabIndex        =   633
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5160
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   21
         Left            =   -66000
         TabIndex        =   632
         Text            =   "10"
         Top             =   5520
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM22"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   21
         Left            =   -67200
         Style           =   1  '圖片外觀
         TabIndex        =   631
         Top             =   5880
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   21
         Left            =   -67200
         TabIndex        =   630
         Text            =   "0"
         Top             =   7800
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   21
         Left            =   -67200
         TabIndex        =   629
         Text            =   "0"
         Top             =   7320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   21
         Left            =   -67200
         TabIndex        =   628
         Text            =   "0"
         Top             =   6840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   21
         Left            =   -67200
         TabIndex        =   627
         Text            =   "0"
         Top             =   6360
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   21
         Left            =   -65160
         TabIndex        =   626
         Text            =   "0"
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   21
         Left            =   -65160
         TabIndex        =   625
         Text            =   "0"
         Top             =   6840
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   21
         Left            =   -65160
         TabIndex        =   624
         Text            =   "0"
         Top             =   7320
         Width           =   855
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   18
         Left            =   -68520
         TabIndex        =   616
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Timer TmrSend 
         Index           =   18
         Left            =   -69000
         Top             =   2400
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   18
         Left            =   -68280
         TabIndex        =   615
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   18
         Left            =   -68280
         TabIndex        =   614
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   18
         Left            =   -68280
         TabIndex        =   613
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   18
         Left            =   -70320
         TabIndex        =   612
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   18
         Left            =   -70320
         TabIndex        =   611
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   18
         Left            =   -70320
         TabIndex        =   610
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   18
         Left            =   -70320
         TabIndex        =   609
         Text            =   "0"
         Top             =   4320
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM19"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   18
         Left            =   -70320
         Style           =   1  '圖片外觀
         TabIndex        =   608
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   18
         Left            =   -69120
         TabIndex        =   607
         Text            =   "10"
         Top             =   2040
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   18
         Left            =   -69120
         TabIndex        =   606
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   18
         Left            =   -70320
         TabIndex        =   605
         Top             =   4680
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   19
         Left            =   -68520
         TabIndex        =   599
         Top             =   5820
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Timer TmrSend 
         Index           =   19
         Left            =   -69000
         Top             =   5820
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   19
         Left            =   -68280
         TabIndex        =   598
         Text            =   "0"
         Top             =   7320
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   19
         Left            =   -68280
         TabIndex        =   597
         Text            =   "0"
         Top             =   6840
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   19
         Left            =   -68280
         TabIndex        =   596
         Text            =   "0"
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   19
         Left            =   -70320
         TabIndex        =   595
         Text            =   "0"
         Top             =   6360
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   19
         Left            =   -70320
         TabIndex        =   594
         Text            =   "0"
         Top             =   6840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   19
         Left            =   -70320
         TabIndex        =   593
         Text            =   "0"
         Top             =   7320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   19
         Left            =   -70320
         TabIndex        =   592
         Text            =   "0"
         Top             =   7800
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM20"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   19
         Left            =   -70320
         Style           =   1  '圖片外觀
         TabIndex        =   591
         Top             =   5880
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   19
         Left            =   -69120
         TabIndex        =   590
         Text            =   "10"
         Top             =   5520
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   19
         Left            =   -69120
         TabIndex        =   589
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5160
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   19
         Left            =   -70320
         TabIndex        =   588
         Top             =   8160
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   17
         Left            =   -73080
         TabIndex        =   582
         Top             =   5820
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Timer TmrSend 
         Index           =   17
         Left            =   -73560
         Top             =   5820
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   17
         Left            =   -71400
         TabIndex        =   581
         Text            =   "0"
         Top             =   7320
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   17
         Left            =   -71400
         TabIndex        =   580
         Text            =   "0"
         Top             =   6840
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   17
         Left            =   -71400
         TabIndex        =   579
         Text            =   "0"
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   17
         Left            =   -73440
         TabIndex        =   578
         Text            =   "0"
         Top             =   6360
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   17
         Left            =   -73440
         TabIndex        =   577
         Text            =   "0"
         Top             =   6840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   17
         Left            =   -73440
         TabIndex        =   576
         Text            =   "0"
         Top             =   7320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   17
         Left            =   -73440
         TabIndex        =   575
         Text            =   "0"
         Top             =   7800
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM18"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   17
         Left            =   -74880
         Style           =   1  '圖片外觀
         TabIndex        =   574
         Top             =   5880
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   17
         Left            =   -72240
         TabIndex        =   573
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   17
         Left            =   -72240
         TabIndex        =   572
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   17
         Left            =   -73440
         TabIndex        =   571
         Top             =   8160
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   16
         Left            =   -72240
         TabIndex        =   565
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   16
         Left            =   -72240
         TabIndex        =   564
         Text            =   "10"
         Top             =   2040
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         Appearance      =   0  '平面
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM17"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   16
         Left            =   -74880
         Style           =   1  '圖片外觀
         TabIndex        =   563
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   16
         Left            =   -73440
         TabIndex        =   562
         Text            =   "0"
         Top             =   4320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   16
         Left            =   -73440
         TabIndex        =   561
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   16
         Left            =   -73440
         TabIndex        =   560
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   16
         Left            =   -73440
         TabIndex        =   559
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   16
         Left            =   -71400
         TabIndex        =   558
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   16
         Left            =   -71400
         TabIndex        =   557
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   16
         Left            =   -71400
         TabIndex        =   556
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.Timer TmrSend 
         Index           =   16
         Left            =   -73560
         Top             =   2400
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   16
         Left            =   -73080
         TabIndex        =   555
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   23
         Left            =   -64080
         TabIndex        =   524
         Top             =   4680
         Visible         =   0   'False
         Width           =   3015
      End
      Begin VB.Frame Frame1 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1215
         Index           =   2
         Left            =   -74880
         TabIndex        =   478
         Top             =   360
         Width           =   14055
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   23
            Left            =   13440
            TabIndex        =   486
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   22
            Left            =   13440
            TabIndex        =   485
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   21
            Left            =   10080
            TabIndex        =   484
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   20
            Left            =   10080
            TabIndex        =   483
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   19
            Left            =   6720
            TabIndex        =   482
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   18
            Left            =   6720
            TabIndex        =   481
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   17
            Left            =   3240
            TabIndex        =   480
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   16
            Left            =   3240
            TabIndex        =   479
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   23
            Left            =   11760
            TabIndex        =   514
            Text            =   "4661"
            Top             =   720
            Width           =   495
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   22
            Left            =   11760
            TabIndex        =   513
            Text            =   "4660"
            Top             =   240
            Width           =   495
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   23
            Left            =   10680
            TabIndex        =   512
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   22
            Left            =   10680
            TabIndex        =   511
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   23
            Left            =   12360
            Style           =   1  '圖片外觀
            TabIndex        =   510
            Top             =   720
            Width           =   1095
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   22
            Left            =   12360
            Style           =   1  '圖片外觀
            TabIndex        =   509
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtStatus1617 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   3360
            MultiLine       =   -1  'True
            TabIndex        =   508
            Top             =   360
            Width           =   375
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   21
            Left            =   9000
            Style           =   1  '圖片外觀
            TabIndex        =   507
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   21
            Left            =   8400
            TabIndex        =   506
            Text            =   "4662"
            Top             =   720
            Width           =   495
         End
         Begin VB.TextBox txtStatus1819 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   6840
            MultiLine       =   -1  'True
            TabIndex        =   505
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   20
            Left            =   8400
            TabIndex        =   504
            Text            =   "4663"
            Top             =   240
            Width           =   495
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   20
            Left            =   9000
            Style           =   1  '圖片外觀
            TabIndex        =   503
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   19
            Left            =   4920
            TabIndex        =   502
            Text            =   "4664"
            Top             =   720
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   19
            Left            =   5640
            Style           =   1  '圖片外觀
            TabIndex        =   501
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtStatus2021 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   10200
            MultiLine       =   -1  'True
            TabIndex        =   500
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   18
            Left            =   4920
            TabIndex        =   499
            Text            =   "4665"
            Top             =   240
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   18
            Left            =   5640
            Style           =   1  '圖片外觀
            TabIndex        =   498
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   17
            Left            =   1440
            TabIndex        =   497
            Text            =   "4666"
            Top             =   720
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   17
            Left            =   2160
            Style           =   1  '圖片外觀
            TabIndex        =   496
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   16
            Left            =   1440
            TabIndex        =   495
            Text            =   "4667"
            Top             =   240
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   16
            Left            =   2160
            Style           =   1  '圖片外觀
            TabIndex        =   494
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtStatus2223 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   13560
            MultiLine       =   -1  'True
            TabIndex        =   493
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   21
            Left            =   7320
            TabIndex        =   492
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   20
            Left            =   7320
            TabIndex        =   491
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   19
            Left            =   3840
            TabIndex        =   490
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   18
            Left            =   3840
            TabIndex        =   489
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   17
            Left            =   360
            TabIndex        =   488
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   16
            Left            =   360
            TabIndex        =   487
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   16
            Left            =   960
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   17
            Left            =   480
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   18
            Left            =   3960
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   19
            Left            =   4440
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   20
            Left            =   7920
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   21
            Left            =   8400
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   22
            Left            =   11040
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   23
            Left            =   11520
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin VB.Label LabLoop 
            Caption         =   "IP:"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   255
            Index           =   8
            Left            =   120
            TabIndex        =   520
            Top             =   240
            Width           =   255
         End
         Begin VB.Label Label41 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   13440
            TabIndex        =   523
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label1 
            Caption         =   "Receive From GW 2 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   5
            Left            =   120
            TabIndex        =   522
            Top             =   720
            Visible         =   0   'False
            Width           =   135
         End
         Begin VB.Label Label1 
            Caption         =   "Send To GW 1 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   4
            Left            =   120
            TabIndex        =   521
            Top             =   360
            Visible         =   0   'False
            Width           =   135
         End
         Begin VB.Label LabLoop 
            Caption         =   "GW 2 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   7
            Left            =   360
            TabIndex        =   519
            Top             =   720
            Visible         =   0   'False
            Width           =   855
         End
         Begin VB.Label LabLoop 
            Caption         =   "IP"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   6
            Left            =   4680
            TabIndex        =   518
            Top             =   600
            Visible         =   0   'False
            Width           =   735
         End
         Begin VB.Label Label40 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   10080
            TabIndex        =   517
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label39 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   6720
            TabIndex        =   516
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label38 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   3240
            TabIndex        =   515
            Top             =   120
            Width           =   540
         End
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   23
         Left            =   -62880
         TabIndex        =   477
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5160
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   23
         Left            =   -62880
         TabIndex        =   476
         Text            =   "10"
         Top             =   5520
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Index           =   22
         Left            =   -64080
         TabIndex        =   475
         Top             =   8160
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM24"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   23
         Left            =   -64080
         Style           =   1  '圖片外觀
         TabIndex        =   474
         Top             =   5880
         Width           =   1215
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   23
         Left            =   -64080
         TabIndex        =   473
         Text            =   "0"
         Top             =   6840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   23
         Left            =   -64080
         TabIndex        =   472
         Text            =   "0"
         Top             =   7320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   23
         Left            =   -64080
         TabIndex        =   471
         Text            =   "0"
         Top             =   7800
         Width           =   1095
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   22
         Left            =   -62880
         TabIndex        =   470
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   22
         Left            =   -62880
         TabIndex        =   469
         Text            =   "10"
         Top             =   2040
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM23"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   22
         Left            =   -64080
         Style           =   1  '圖片外觀
         TabIndex        =   468
         Top             =   2400
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   22
         Left            =   -64080
         TabIndex        =   467
         Text            =   "0"
         Top             =   4320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   22
         Left            =   -64080
         TabIndex        =   466
         Text            =   "0"
         Top             =   3840
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   22
         Left            =   -64080
         TabIndex        =   465
         Text            =   "0"
         Top             =   3360
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   23
         Left            =   -64080
         TabIndex        =   464
         Text            =   "0"
         Top             =   2880
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   22
         Left            =   -64080
         TabIndex        =   463
         Text            =   "0"
         Top             =   6360
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   23
         Left            =   -62040
         TabIndex        =   462
         Text            =   "0"
         Top             =   6360
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   23
         Left            =   -62040
         TabIndex        =   461
         Text            =   "0"
         Top             =   6840
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   23
         Left            =   -62040
         TabIndex        =   460
         Text            =   "0"
         Top             =   7320
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   22
         Left            =   -62040
         TabIndex        =   459
         Text            =   "0"
         Top             =   2880
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   22
         Left            =   -62040
         TabIndex        =   458
         Text            =   "0"
         Top             =   3360
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   22
         Left            =   -62040
         TabIndex        =   457
         Text            =   "0"
         Top             =   3840
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   20
         Left            =   -67200
         TabIndex        =   456
         Top             =   4680
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   20
         Left            =   -66000
         TabIndex        =   455
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   20
         Left            =   -66000
         TabIndex        =   454
         Text            =   "10"
         Top             =   2040
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM21"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   20
         Left            =   -67200
         Style           =   1  '圖片外觀
         TabIndex        =   453
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   20
         Left            =   -67200
         TabIndex        =   452
         Text            =   "0"
         Top             =   4320
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   20
         Left            =   -67200
         TabIndex        =   451
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   20
         Left            =   -67200
         TabIndex        =   450
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   20
         Left            =   -67200
         TabIndex        =   449
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   20
         Left            =   -65160
         TabIndex        =   448
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   20
         Left            =   -65160
         TabIndex        =   447
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   20
         Left            =   -65160
         TabIndex        =   446
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   16
         Left            =   -73440
         TabIndex        =   445
         Top             =   4680
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.Timer TmrSend 
         Index           =   23
         Left            =   -62760
         Top             =   5820
      End
      Begin VB.Timer TmrSend 
         Index           =   22
         Left            =   -62760
         Top             =   2400
      End
      Begin VB.Timer TmrSend 
         Index           =   20
         Left            =   -65880
         Top             =   2400
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   23
         Left            =   -62280
         TabIndex        =   444
         Top             =   5820
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   22
         Left            =   -62280
         TabIndex        =   443
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   20
         Left            =   -65400
         TabIndex        =   442
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   15
         Left            =   -62280
         TabIndex        =   441
         Top             =   6000
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   14
         Left            =   -62280
         TabIndex        =   440
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   13
         Left            =   -65400
         TabIndex        =   439
         Top             =   6000
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   12
         Left            =   -65400
         TabIndex        =   438
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   11
         Left            =   -68520
         TabIndex        =   437
         Top             =   6000
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   10
         Left            =   -68520
         TabIndex        =   436
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   9
         Left            =   -73080
         TabIndex        =   435
         Top             =   5880
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   8
         Left            =   -73080
         TabIndex        =   434
         Top             =   2520
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   1920
         TabIndex        =   433
         Top             =   2520
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   2040
         TabIndex        =   432
         Top             =   6000
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   6480
         TabIndex        =   431
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   6480
         TabIndex        =   430
         Top             =   6000
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   4
         Left            =   9600
         TabIndex        =   429
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   5
         Left            =   9600
         TabIndex        =   428
         Top             =   6000
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   6
         Left            =   12720
         TabIndex        =   427
         Top             =   2400
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.CommandButton CmdClrCnt 
         Appearance      =   0  '平面
         Caption         =   "Clear Counter"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   7
         Left            =   12720
         TabIndex        =   426
         Top             =   6000
         Visible         =   0   'False
         Width           =   495
      End
      Begin VB.Timer TmrSend 
         Index           =   15
         Left            =   -62760
         Top             =   6000
      End
      Begin VB.Timer TmrSend 
         Index           =   14
         Left            =   -62760
         Top             =   2400
      End
      Begin VB.Timer TmrSend 
         Index           =   13
         Left            =   -65880
         Top             =   6000
      End
      Begin VB.Timer TmrSend 
         Index           =   12
         Left            =   -65880
         Top             =   2400
      End
      Begin VB.Timer TmrSend 
         Index           =   11
         Left            =   -69000
         Top             =   6000
      End
      Begin VB.Timer TmrSend 
         Index           =   10
         Left            =   -69000
         Top             =   2400
      End
      Begin VB.Timer TmrSend 
         Index           =   9
         Left            =   -73560
         Top             =   5880
      End
      Begin VB.Timer TmrSend 
         Index           =   8
         Left            =   -73560
         Top             =   2520
      End
      Begin VB.Timer TmrSend 
         Index           =   0
         Left            =   1440
         Top             =   2520
      End
      Begin VB.Timer TmrSend 
         Index           =   1
         Left            =   1560
         Top             =   6000
      End
      Begin VB.Timer TmrSend 
         Index           =   2
         Left            =   6000
         Top             =   2400
      End
      Begin VB.Timer TmrSend 
         Index           =   3
         Left            =   6000
         Top             =   6000
      End
      Begin VB.Timer TmrSend 
         Index           =   4
         Left            =   9120
         Top             =   2400
      End
      Begin VB.Timer TmrSend 
         Index           =   5
         Left            =   9120
         Top             =   6000
      End
      Begin VB.Timer TmrSend 
         Index           =   6
         Left            =   12240
         Top             =   2400
      End
      Begin VB.Timer TmrSend 
         Index           =   7
         Left            =   12240
         Top             =   6000
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   15
         Left            =   -62040
         TabIndex        =   367
         Text            =   "0"
         Top             =   7440
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   15
         Left            =   -62040
         TabIndex        =   366
         Text            =   "0"
         Top             =   6960
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   15
         Left            =   -62040
         TabIndex        =   365
         Text            =   "0"
         Top             =   6480
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   15
         Left            =   -64080
         TabIndex        =   364
         Text            =   "0"
         Top             =   6480
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   15
         Left            =   -64080
         TabIndex        =   363
         Text            =   "0"
         Top             =   6960
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   15
         Left            =   -64080
         TabIndex        =   362
         Text            =   "0"
         Top             =   7440
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   15
         Left            =   -64080
         TabIndex        =   361
         Text            =   "0"
         Top             =   7860
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM16"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   15
         Left            =   -64080
         Style           =   1  '圖片外觀
         TabIndex        =   360
         Top             =   6000
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   15
         Left            =   -62880
         TabIndex        =   359
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   15
         Left            =   -62880
         TabIndex        =   358
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   15
         Left            =   -64080
         TabIndex        =   357
         Top             =   8220
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   14
         Left            =   -62040
         TabIndex        =   356
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   14
         Left            =   -62040
         TabIndex        =   355
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   14
         Left            =   -62040
         TabIndex        =   354
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   14
         Left            =   -64080
         TabIndex        =   353
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   14
         Left            =   -64080
         TabIndex        =   352
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   14
         Left            =   -64080
         TabIndex        =   351
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   14
         Left            =   -64080
         TabIndex        =   350
         Text            =   "0"
         Top             =   4380
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM15"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   14
         Left            =   -64080
         Style           =   1  '圖片外觀
         TabIndex        =   349
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   14
         Left            =   -62880
         TabIndex        =   348
         Text            =   "10"
         Top             =   2100
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   14
         Left            =   -62880
         TabIndex        =   347
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1740
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   14
         Left            =   -64080
         TabIndex        =   346
         Top             =   4740
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   13
         Left            =   -65160
         TabIndex        =   345
         Text            =   "0"
         Top             =   7440
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   13
         Left            =   -65160
         TabIndex        =   344
         Text            =   "0"
         Top             =   6960
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   13
         Left            =   -65160
         TabIndex        =   343
         Text            =   "0"
         Top             =   6480
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   13
         Left            =   -67200
         TabIndex        =   342
         Text            =   "0"
         Top             =   6480
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   13
         Left            =   -67200
         TabIndex        =   341
         Text            =   "0"
         Top             =   6960
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   13
         Left            =   -67200
         TabIndex        =   340
         Text            =   "0"
         Top             =   7440
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   13
         Left            =   -67200
         TabIndex        =   339
         Text            =   "0"
         Top             =   7860
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM14"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   13
         Left            =   -67200
         Style           =   1  '圖片外觀
         TabIndex        =   338
         Top             =   6000
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   13
         Left            =   -66000
         TabIndex        =   337
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   13
         Left            =   -66000
         TabIndex        =   336
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   13
         Left            =   -67200
         TabIndex        =   335
         Top             =   8220
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   12
         Left            =   -65160
         TabIndex        =   334
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   12
         Left            =   -65160
         TabIndex        =   333
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   12
         Left            =   -65160
         TabIndex        =   332
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   12
         Left            =   -67200
         TabIndex        =   331
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   12
         Left            =   -67200
         TabIndex        =   330
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   12
         Left            =   -67200
         TabIndex        =   329
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   12
         Left            =   -67200
         TabIndex        =   328
         Text            =   "0"
         Top             =   4380
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM13"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   12
         Left            =   -67200
         Style           =   1  '圖片外觀
         TabIndex        =   327
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   12
         Left            =   -66000
         TabIndex        =   326
         Text            =   "10"
         Top             =   2100
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   12
         Left            =   -66000
         TabIndex        =   325
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1740
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   12
         Left            =   -67200
         TabIndex        =   324
         Top             =   4740
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   11
         Left            =   -68280
         TabIndex        =   323
         Text            =   "0"
         Top             =   7440
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   11
         Left            =   -68280
         TabIndex        =   322
         Text            =   "0"
         Top             =   6960
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   11
         Left            =   -68280
         TabIndex        =   321
         Text            =   "0"
         Top             =   6480
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   11
         Left            =   -70320
         TabIndex        =   320
         Text            =   "0"
         Top             =   6480
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   11
         Left            =   -70320
         TabIndex        =   319
         Text            =   "0"
         Top             =   6960
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   11
         Left            =   -70320
         TabIndex        =   318
         Text            =   "0"
         Top             =   7440
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   11
         Left            =   -70320
         TabIndex        =   317
         Text            =   "0"
         Top             =   7860
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM12"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   11
         Left            =   -70320
         Style           =   1  '圖片外觀
         TabIndex        =   316
         Top             =   6000
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   11
         Left            =   -69120
         TabIndex        =   315
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   11
         Left            =   -69120
         TabIndex        =   314
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   11
         Left            =   -70320
         TabIndex        =   313
         Top             =   8220
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   10
         Left            =   -70320
         TabIndex        =   312
         Top             =   4740
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   10
         Left            =   -69120
         TabIndex        =   311
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1740
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   10
         Left            =   -69120
         TabIndex        =   310
         Text            =   "10"
         Top             =   2100
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM11"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   10
         Left            =   -70320
         Style           =   1  '圖片外觀
         TabIndex        =   309
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   10
         Left            =   -70320
         TabIndex        =   308
         Text            =   "0"
         Top             =   4380
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   10
         Left            =   -70320
         TabIndex        =   307
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   10
         Left            =   -70320
         TabIndex        =   306
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   10
         Left            =   -70320
         TabIndex        =   305
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   10
         Left            =   -68280
         TabIndex        =   304
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   10
         Left            =   -68280
         TabIndex        =   303
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   10
         Left            =   -68280
         TabIndex        =   302
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   9
         Left            =   -71400
         TabIndex        =   301
         Text            =   "0"
         Top             =   7380
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   9
         Left            =   -71400
         TabIndex        =   300
         Text            =   "0"
         Top             =   6900
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   9
         Left            =   -71400
         TabIndex        =   299
         Text            =   "0"
         Top             =   6420
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   8
         Left            =   -71400
         TabIndex        =   298
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   8
         Left            =   -71400
         TabIndex        =   297
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   8
         Left            =   -71400
         TabIndex        =   296
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   9
         Left            =   -73440
         TabIndex        =   295
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   8
         Left            =   -73440
         TabIndex        =   294
         Text            =   "0"
         Top             =   6420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   9
         Left            =   -73440
         TabIndex        =   293
         Text            =   "0"
         Top             =   6900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   9
         Left            =   -73440
         TabIndex        =   292
         Text            =   "0"
         Top             =   7380
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   9
         Left            =   -73440
         TabIndex        =   291
         Text            =   "0"
         Top             =   7860
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM10"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   9
         Left            =   -74880
         Style           =   1  '圖片外觀
         TabIndex        =   290
         Top             =   5940
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   9
         Left            =   -72240
         TabIndex        =   289
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   9
         Left            =   -72240
         TabIndex        =   288
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   8
         Left            =   -73440
         TabIndex        =   287
         Text            =   "0"
         Top             =   4380
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   8
         Left            =   -73440
         TabIndex        =   286
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   8
         Left            =   -73440
         TabIndex        =   285
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM9"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   8
         Left            =   -74880
         Style           =   1  '圖片外觀
         TabIndex        =   284
         Top             =   2520
         Width           =   1215
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Index           =   9
         Left            =   -73440
         TabIndex        =   283
         Top             =   4740
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   8
         Left            =   -72240
         TabIndex        =   282
         Text            =   "10"
         Top             =   2100
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   8
         Left            =   -72240
         TabIndex        =   281
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1740
         Width           =   855
      End
      Begin VB.Frame Frame1 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1215
         Index           =   1
         Left            =   -74880
         TabIndex        =   235
         Top             =   420
         Width           =   14055
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   13
            Left            =   10080
            TabIndex        =   254
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   12
            Left            =   10080
            TabIndex        =   248
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   11
            Left            =   6720
            TabIndex        =   241
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   10
            Left            =   6720
            TabIndex        =   240
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   9
            Left            =   3240
            TabIndex        =   237
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   8
            Left            =   3240
            TabIndex        =   236
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   14
            Left            =   13440
            TabIndex        =   260
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   15
            Left            =   13440
            TabIndex        =   263
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   15
            Left            =   10680
            TabIndex        =   271
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   14
            Left            =   10680
            TabIndex        =   270
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   13
            Left            =   7320
            TabIndex        =   269
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   12
            Left            =   7320
            TabIndex        =   268
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   11
            Left            =   3840
            TabIndex        =   267
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   10
            Left            =   3840
            TabIndex        =   266
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtStatus1415 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   13560
            MultiLine       =   -1  'True
            TabIndex        =   265
            Top             =   360
            Width           =   375
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   15
            Left            =   12360
            Style           =   1  '圖片外觀
            TabIndex        =   264
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   15
            Left            =   11760
            TabIndex        =   262
            Text            =   "4667"
            Top             =   720
            Width           =   495
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   14
            Left            =   12360
            Style           =   1  '圖片外觀
            TabIndex        =   261
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   14
            Left            =   11760
            TabIndex        =   259
            Text            =   "4666"
            Top             =   240
            Width           =   495
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   13
            Left            =   9000
            Style           =   1  '圖片外觀
            TabIndex        =   258
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   13
            Left            =   8400
            TabIndex        =   257
            Text            =   "4665"
            Top             =   720
            Width           =   495
         End
         Begin VB.TextBox txtStatus1213 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   10200
            MultiLine       =   -1  'True
            TabIndex        =   256
            Top             =   360
            Width           =   375
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   12
            Left            =   9000
            Style           =   1  '圖片外觀
            TabIndex        =   255
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   12
            Left            =   8400
            TabIndex        =   253
            Text            =   "4664"
            Top             =   240
            Width           =   495
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   11
            Left            =   5640
            Style           =   1  '圖片外觀
            TabIndex        =   252
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   11
            Left            =   4920
            TabIndex        =   251
            Text            =   "4663"
            Top             =   720
            Width           =   615
         End
         Begin VB.TextBox txtStatus1011 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   6840
            MultiLine       =   -1  'True
            TabIndex        =   250
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   10
            Left            =   4920
            TabIndex        =   249
            Text            =   "4662"
            Top             =   240
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   10
            Left            =   5640
            Style           =   1  '圖片外觀
            TabIndex        =   247
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtStatus89 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   3360
            MultiLine       =   -1  'True
            TabIndex        =   246
            Top             =   360
            Width           =   375
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   9
            Left            =   2160
            Style           =   1  '圖片外觀
            TabIndex        =   245
            Top             =   720
            Width           =   1095
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   8
            Left            =   2160
            Style           =   1  '圖片外觀
            TabIndex        =   244
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   9
            Left            =   360
            TabIndex        =   243
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   8
            Left            =   360
            TabIndex        =   242
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   9
            Left            =   1440
            TabIndex        =   239
            Text            =   "4660"
            Top             =   720
            Width           =   615
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   8
            Left            =   1440
            TabIndex        =   238
            Text            =   "4661"
            Top             =   240
            Width           =   615
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   8
            Left            =   960
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   9
            Left            =   480
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   10
            Left            =   3960
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   11
            Left            =   4440
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   12
            Left            =   7920
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   13
            Left            =   8400
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   14
            Left            =   11040
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   15
            Left            =   11520
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin VB.Label Label37 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   13440
            TabIndex        =   280
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label36 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   10080
            TabIndex        =   279
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label35 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   6720
            TabIndex        =   278
            Top             =   120
            Width           =   540
         End
         Begin VB.Label LabLoop 
            Caption         =   "IP"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   5
            Left            =   4680
            TabIndex        =   277
            Top             =   600
            Visible         =   0   'False
            Width           =   735
         End
         Begin VB.Label LabLoop 
            Caption         =   "GW 2 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   4
            Left            =   360
            TabIndex        =   276
            Top             =   720
            Visible         =   0   'False
            Width           =   855
         End
         Begin VB.Label LabLoop 
            Caption         =   "IP:"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   255
            Index           =   3
            Left            =   120
            TabIndex        =   275
            Top             =   240
            Width           =   255
         End
         Begin VB.Label Label1 
            Caption         =   "Send To GW 1 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   3
            Left            =   120
            TabIndex        =   274
            Top             =   360
            Visible         =   0   'False
            Width           =   135
         End
         Begin VB.Label Label1 
            Caption         =   "Receive From GW 2 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   2
            Left            =   120
            TabIndex        =   273
            Top             =   720
            Visible         =   0   'False
            Width           =   135
         End
         Begin VB.Label Label34 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   3240
            TabIndex        =   272
            Top             =   120
            Width           =   540
         End
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   8
         Left            =   -73440
         TabIndex        =   234
         Top             =   8220
         Visible         =   0   'False
         Width           =   3015
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   1560
         TabIndex        =   175
         Top             =   8220
         Visible         =   0   'False
         Width           =   3015
      End
      Begin VB.Frame Frame1 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1215
         Index           =   0
         Left            =   120
         TabIndex        =   129
         Top             =   420
         Width           =   14055
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   5
            Left            =   10080
            TabIndex        =   165
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   3
            Left            =   6720
            TabIndex        =   164
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   1
            Left            =   1440
            TabIndex        =   163
            Text            =   "4661"
            Top             =   720
            Width           =   615
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   0
            Left            =   1440
            TabIndex        =   162
            Text            =   "4660"
            Top             =   240
            Width           =   615
         End
         Begin VB.TextBox txtLocalPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   1
            Left            =   3240
            TabIndex        =   161
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtLocalPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   0
            Left            =   3240
            TabIndex        =   160
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   1
            Left            =   360
            TabIndex        =   159
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   0
            Left            =   360
            TabIndex        =   158
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   1
            Left            =   2160
            Style           =   1  '圖片外觀
            TabIndex        =   157
            Top             =   720
            Width           =   1095
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   0
            Left            =   2160
            Style           =   1  '圖片外觀
            TabIndex        =   156
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtStatus01 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   3360
            MultiLine       =   -1  'True
            TabIndex        =   155
            Top             =   360
            Width           =   375
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   2
            Left            =   5640
            Style           =   1  '圖片外觀
            TabIndex        =   154
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   2
            Left            =   6720
            TabIndex        =   153
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   2
            Left            =   4920
            TabIndex        =   152
            Text            =   "4662"
            Top             =   240
            Width           =   615
         End
         Begin VB.TextBox txtStatus23 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   6840
            MultiLine       =   -1  'True
            TabIndex        =   151
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   3
            Left            =   4920
            TabIndex        =   150
            Text            =   "4663"
            Top             =   720
            Width           =   615
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   3
            Left            =   5640
            Style           =   1  '圖片外觀
            TabIndex        =   149
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   4
            Left            =   8400
            TabIndex        =   148
            Text            =   "4664"
            Top             =   240
            Width           =   495
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   4
            Left            =   10080
            TabIndex        =   147
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   4
            Left            =   9000
            Style           =   1  '圖片外觀
            TabIndex        =   146
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtStatus45 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   10200
            MultiLine       =   -1  'True
            TabIndex        =   145
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   5
            Left            =   8400
            TabIndex        =   144
            Text            =   "4665"
            Top             =   720
            Width           =   495
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   5
            Left            =   9000
            Style           =   1  '圖片外觀
            TabIndex        =   143
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   6
            Left            =   11760
            TabIndex        =   142
            Text            =   "4666"
            Top             =   240
            Width           =   495
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   6
            Left            =   13440
            TabIndex        =   141
            Text            =   "0"
            Top             =   240
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   6
            Left            =   12360
            Style           =   1  '圖片外觀
            TabIndex        =   140
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtPort 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   7
            Left            =   11760
            TabIndex        =   139
            Text            =   "4667"
            Top             =   720
            Width           =   495
         End
         Begin VB.TextBox txtLocalPort 
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   7
            Left            =   13440
            TabIndex        =   138
            Text            =   "0"
            Top             =   720
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.CommandButton cmdCnect 
            BackColor       =   &H00C0FFC0&
            Caption         =   "Connect"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   7
            Left            =   12360
            Style           =   1  '圖片外觀
            TabIndex        =   137
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtStatus67 
            Alignment       =   2  '置中對齊
            BackColor       =   &H00C0FFFF&
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9.75
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00008000&
            Height          =   735
            Left            =   13560
            MultiLine       =   -1  'True
            TabIndex        =   136
            Top             =   360
            Width           =   375
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   7
            Left            =   10680
            TabIndex        =   135
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   6
            Left            =   10680
            TabIndex        =   134
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   5
            Left            =   7320
            TabIndex        =   133
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   4
            Left            =   7320
            TabIndex        =   132
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   3
            Left            =   3840
            TabIndex        =   131
            Text            =   "10.0.50.100"
            Top             =   720
            Width           =   1095
         End
         Begin VB.TextBox txtip 
            Alignment       =   2  '置中對齊
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   375
            Index           =   2
            Left            =   3840
            TabIndex        =   130
            Text            =   "10.0.50.100"
            Top             =   240
            Width           =   1095
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   3
            Left            =   5280
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   2
            Left            =   4800
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   0
            Left            =   360
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   1
            Left            =   840
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   4
            Left            =   7920
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   5
            Left            =   8400
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   6
            Left            =   11040
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin MSWinsockLib.Winsock Winsock1 
            Index           =   7
            Left            =   11520
            Top             =   960
            _ExtentX        =   741
            _ExtentY        =   741
            _Version        =   393216
         End
         Begin VB.Label LabLoop 
            Caption         =   "IP:"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   9
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00000000&
            Height          =   255
            Index           =   0
            Left            =   120
            TabIndex        =   171
            Top             =   240
            Width           =   255
         End
         Begin VB.Label Label6 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   3240
            TabIndex        =   174
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label1 
            Caption         =   "Receive From GW 2 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   1
            Left            =   120
            TabIndex        =   173
            Top             =   720
            Visible         =   0   'False
            Width           =   135
         End
         Begin VB.Label Label1 
            Caption         =   "Send To GW 1 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   0
            Left            =   120
            TabIndex        =   172
            Top             =   360
            Visible         =   0   'False
            Width           =   135
         End
         Begin VB.Label LabLoop 
            Caption         =   "GW 2 :"
            BeginProperty Font 
               Name            =   "Arial"
               Size            =   11.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   1
            Left            =   360
            TabIndex        =   170
            Top             =   720
            Visible         =   0   'False
            Width           =   855
         End
         Begin VB.Label LabLoop 
            Caption         =   "IP"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Index           =   2
            Left            =   4680
            TabIndex        =   169
            Top             =   600
            Visible         =   0   'False
            Width           =   735
         End
         Begin VB.Label Label21 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   6720
            TabIndex        =   168
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label30 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   10080
            TabIndex        =   167
            Top             =   120
            Width           =   540
         End
         Begin VB.Label Label31 
            AutoSize        =   -1  'True
            Caption         =   "Status :"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   13440
            TabIndex        =   166
            Top             =   120
            Width           =   540
         End
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   0
         Left            =   2760
         TabIndex        =   128
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1740
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   0
         Left            =   2760
         TabIndex        =   127
         Text            =   "10"
         Top             =   2100
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Index           =   0
         Left            =   1560
         TabIndex        =   126
         Top             =   4740
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM1"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         Style           =   1  '圖片外觀
         TabIndex        =   125
         Top             =   2520
         Width           =   1215
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   0
         Left            =   1560
         TabIndex        =   124
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   0
         Left            =   1560
         TabIndex        =   123
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   0
         Left            =   1560
         TabIndex        =   122
         Text            =   "0"
         Top             =   4380
         Width           =   1095
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   1
         Left            =   2760
         TabIndex        =   121
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   1
         Left            =   2760
         TabIndex        =   120
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM2"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   120
         Style           =   1  '圖片外觀
         TabIndex        =   119
         Top             =   5940
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   1
         Left            =   1560
         TabIndex        =   118
         Text            =   "0"
         Top             =   7860
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   1
         Left            =   1560
         TabIndex        =   117
         Text            =   "0"
         Top             =   7380
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   1
         Left            =   1560
         TabIndex        =   116
         Text            =   "0"
         Top             =   6900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   1
         Left            =   1560
         TabIndex        =   115
         Text            =   "0"
         Top             =   6420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   0
         Left            =   1560
         TabIndex        =   114
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   0
         Left            =   3600
         TabIndex        =   113
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   3600
         TabIndex        =   112
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   0
         Left            =   3600
         TabIndex        =   111
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   1
         Left            =   3600
         TabIndex        =   110
         Text            =   "0"
         Top             =   6420
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   3600
         TabIndex        =   109
         Text            =   "0"
         Top             =   6900
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   1
         Left            =   3600
         TabIndex        =   108
         Text            =   "0"
         Top             =   7380
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   2
         Left            =   6720
         TabIndex        =   107
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   6720
         TabIndex        =   106
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   2
         Left            =   6720
         TabIndex        =   105
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   2
         Left            =   4680
         TabIndex        =   104
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   2
         Left            =   4680
         TabIndex        =   103
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   2
         Left            =   4680
         TabIndex        =   102
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   2
         Left            =   4680
         TabIndex        =   101
         Text            =   "0"
         Top             =   4380
         Width           =   1095
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM3"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   4680
         Style           =   1  '圖片外觀
         TabIndex        =   100
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   2
         Left            =   5880
         TabIndex        =   99
         Text            =   "10"
         Top             =   2100
         Width           =   855
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   2
         Left            =   5880
         TabIndex        =   98
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1740
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   4680
         TabIndex        =   97
         Top             =   4740
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   4680
         TabIndex        =   96
         Top             =   8220
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   3
         Left            =   5880
         TabIndex        =   95
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   3
         Left            =   5880
         TabIndex        =   94
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM4"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   4680
         Style           =   1  '圖片外觀
         TabIndex        =   93
         Top             =   6000
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   3
         Left            =   4680
         TabIndex        =   92
         Text            =   "0"
         Top             =   7860
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   3
         Left            =   4680
         TabIndex        =   91
         Text            =   "0"
         Top             =   7440
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   3
         Left            =   4680
         TabIndex        =   90
         Text            =   "0"
         Top             =   6960
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   3
         Left            =   4680
         TabIndex        =   89
         Text            =   "0"
         Top             =   6480
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   3
         Left            =   6720
         TabIndex        =   88
         Text            =   "0"
         Top             =   6480
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   6720
         TabIndex        =   87
         Text            =   "0"
         Top             =   6960
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   3
         Left            =   6720
         TabIndex        =   86
         Text            =   "0"
         Top             =   7440
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   7800
         TabIndex        =   85
         Top             =   4740
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   4
         Left            =   9000
         TabIndex        =   84
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1740
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   4
         Left            =   9000
         TabIndex        =   83
         Text            =   "10"
         Top             =   2100
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM5"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   7800
         Style           =   1  '圖片外觀
         TabIndex        =   82
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   4
         Left            =   7800
         TabIndex        =   81
         Text            =   "0"
         Top             =   4380
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   4
         Left            =   7800
         TabIndex        =   80
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   4
         Left            =   7800
         TabIndex        =   79
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   4
         Left            =   7800
         TabIndex        =   78
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   4
         Left            =   9840
         TabIndex        =   77
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   9840
         TabIndex        =   76
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   4
         Left            =   9840
         TabIndex        =   75
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   7800
         TabIndex        =   74
         Top             =   8220
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   5
         Left            =   9000
         TabIndex        =   73
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   5
         Left            =   9000
         TabIndex        =   72
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM6"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   7800
         Style           =   1  '圖片外觀
         TabIndex        =   71
         Top             =   6000
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   5
         Left            =   7800
         TabIndex        =   70
         Text            =   "0"
         Top             =   7860
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   5
         Left            =   7800
         TabIndex        =   69
         Text            =   "0"
         Top             =   7440
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   5
         Left            =   7800
         TabIndex        =   68
         Text            =   "0"
         Top             =   6960
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   5
         Left            =   7800
         TabIndex        =   67
         Text            =   "0"
         Top             =   6480
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   5
         Left            =   9840
         TabIndex        =   66
         Text            =   "0"
         Top             =   6480
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   9840
         TabIndex        =   65
         Text            =   "0"
         Top             =   6960
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   5
         Left            =   9840
         TabIndex        =   64
         Text            =   "0"
         Top             =   7440
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   10920
         TabIndex        =   63
         Top             =   4740
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   6
         Left            =   12120
         TabIndex        =   62
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   1740
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   6
         Left            =   12120
         TabIndex        =   61
         Text            =   "10"
         Top             =   2100
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM7"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   10920
         Style           =   1  '圖片外觀
         TabIndex        =   60
         Top             =   2460
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   6
         Left            =   10920
         TabIndex        =   59
         Text            =   "0"
         Top             =   4380
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   6
         Left            =   10920
         TabIndex        =   58
         Text            =   "0"
         Top             =   3900
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   6
         Left            =   10920
         TabIndex        =   57
         Text            =   "0"
         Top             =   3420
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   6
         Left            =   10920
         TabIndex        =   56
         Text            =   "0"
         Top             =   2940
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   6
         Left            =   12960
         TabIndex        =   55
         Text            =   "0"
         Top             =   2940
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   12960
         TabIndex        =   54
         Text            =   "0"
         Top             =   3420
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   6
         Left            =   12960
         TabIndex        =   53
         Text            =   "0"
         Top             =   3900
         Width           =   855
      End
      Begin VB.TextBox TxtSendData 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   10920
         TabIndex        =   52
         Top             =   8220
         Visible         =   0   'False
         Width           =   2895
      End
      Begin VB.TextBox TxtSendIntval 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   7
         Left            =   12120
         TabIndex        =   51
         Text            =   "1000"
         ToolTipText     =   "=0: waiting response; >0: period sending"
         Top             =   5220
         Width           =   855
      End
      Begin VB.TextBox TxtSendDataLen 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Index           =   7
         Left            =   12120
         TabIndex        =   50
         Text            =   "10"
         Top             =   5580
         Width           =   855
      End
      Begin VB.CommandButton CmdSendBeg 
         BackColor       =   &H00FFC0C0&
         Caption         =   "Start COM8"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   10920
         Style           =   1  '圖片外觀
         TabIndex        =   49
         Top             =   6000
         Width           =   1215
      End
      Begin VB.TextBox TxtCntLoss 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Index           =   7
         Left            =   10920
         TabIndex        =   48
         Text            =   "0"
         Top             =   7860
         Width           =   1095
      End
      Begin VB.TextBox TxtCntRcv 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   7
         Left            =   10920
         TabIndex        =   47
         Text            =   "0"
         Top             =   7440
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSend 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   375
         Index           =   7
         Left            =   10920
         TabIndex        =   46
         Text            =   "0"
         Top             =   6960
         Width           =   1095
      End
      Begin VB.TextBox TxtCntSendTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   375
         Index           =   7
         Left            =   10920
         TabIndex        =   45
         Text            =   "0"
         Top             =   6480
         Width           =   1095
      End
      Begin VB.TextBox TxtSendPketTal 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   7
         Left            =   12960
         TabIndex        =   44
         Text            =   "0"
         Top             =   6480
         Width           =   855
      End
      Begin VB.TextBox TxtSendPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   12960
         TabIndex        =   43
         Text            =   "0"
         Top             =   6960
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.TextBox TxtRcvPket 
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008080&
         Height          =   375
         Index           =   7
         Left            =   12960
         TabIndex        =   42
         Text            =   "0"
         Top             =   7440
         Width           =   855
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   27
         Left            =   -69120
         TabIndex        =   841
         Top             =   6360
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   27
         Left            =   -69120
         TabIndex        =   840
         Top             =   7320
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   27
         Left            =   -69120
         TabIndex        =   839
         Top             =   7800
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   27
         Left            =   -68280
         TabIndex        =   838
         Top             =   6120
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   27
         Left            =   -69120
         TabIndex        =   837
         Top             =   6840
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   26
         Left            =   -69120
         TabIndex        =   824
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   26
         Left            =   -69120
         TabIndex        =   823
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   26
         Left            =   -69120
         TabIndex        =   822
         Top             =   4320
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   26
         Left            =   -68280
         TabIndex        =   821
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   26
         Left            =   -69120
         TabIndex        =   820
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label4 
         Caption         =   "Port"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -69720
         TabIndex        =   819
         Top             =   4440
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label Label2 
         Caption         =   "IP"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -69960
         TabIndex        =   818
         Top             =   4440
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.Label Label20 
         BackStyle       =   0  '透明
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Index           =   25
         Left            =   -72240
         TabIndex        =   805
         Top             =   6360
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   25
         Left            =   -72240
         TabIndex        =   804
         Top             =   7320
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   25
         Left            =   -72240
         TabIndex        =   803
         Top             =   7800
         Width           =   615
      End
      Begin VB.Label Label24 
         AutoSize        =   -1  'True
         BackStyle       =   0  '透明
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   25
         Left            =   -71400
         TabIndex        =   802
         Top             =   6120
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   25
         Left            =   -72240
         TabIndex        =   801
         Top             =   6840
         Width           =   615
      End
      Begin VB.Label Label24 
         AutoSize        =   -1  'True
         BackStyle       =   0  '透明
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   31
         Left            =   -62040
         TabIndex        =   788
         Top             =   6120
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   31
         Left            =   -62880
         TabIndex        =   787
         Top             =   6840
         Width           =   615
      End
      Begin VB.Label Label20 
         BackStyle       =   0  '透明
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   31
         Left            =   -62880
         TabIndex        =   786
         Top             =   6360
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   31
         Left            =   -62880
         TabIndex        =   785
         Top             =   7320
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   31
         Left            =   -62880
         TabIndex        =   784
         Top             =   7800
         Width           =   615
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   11
         Left            =   -71520
         TabIndex        =   759
         Top             =   7860
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   10
         Left            =   -71520
         TabIndex        =   758
         Top             =   4320
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label Label8 
         Caption         =   "Label8"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   15
         Index           =   3
         Left            =   -72720
         TabIndex        =   757
         Top             =   3000
         Width           =   15
      End
      Begin VB.Label Label5 
         Caption         =   "Sending Data Length (bytes) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   756
         Top             =   2040
         Width           =   2295
      End
      Begin VB.Label Label12 
         Caption         =   "Sending Interval (ms) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   755
         Top             =   1680
         Width           =   1695
      End
      Begin VB.Label Label15 
         Caption         =   "Send Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   754
         Top             =   3360
         Width           =   1095
      End
      Begin VB.Label Label16 
         Caption         =   "Receive Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   753
         Top             =   3840
         Width           =   1215
      End
      Begin VB.Label Label17 
         Caption         =   "Total Loss :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   752
         Top             =   4320
         Width           =   975
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   30
         Left            =   -62040
         TabIndex        =   751
         Top             =   2640
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   30
         Left            =   -62880
         TabIndex        =   750
         Top             =   4320
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   30
         Left            =   -62880
         TabIndex        =   749
         Top             =   3840
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   30
         Left            =   -62880
         TabIndex        =   748
         Top             =   2880
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   30
         Left            =   -62880
         TabIndex        =   747
         Top             =   3360
         Width           =   615
      End
      Begin VB.Label Label19 
         Caption         =   "SendTotal Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   746
         Top             =   2880
         Width           =   1335
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   29
         Left            =   -66000
         TabIndex        =   745
         Top             =   6360
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   29
         Left            =   -66000
         TabIndex        =   744
         Top             =   7320
         Width           =   615
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   9
         Left            =   -67200
         TabIndex        =   743
         Top             =   6240
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   29
         Left            =   -66000
         TabIndex        =   742
         Top             =   7800
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   29
         Left            =   -65160
         TabIndex        =   741
         Top             =   6120
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   29
         Left            =   -66000
         TabIndex        =   740
         Top             =   6840
         Width           =   615
      End
      Begin VB.Label Label23 
         Caption         =   "SendTotal Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   739
         Top             =   6360
         Width           =   1335
      End
      Begin VB.Label Label25 
         Caption         =   "Total Loss :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   738
         Top             =   7800
         Width           =   975
      End
      Begin VB.Label Label26 
         Caption         =   "Receive Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   737
         Top             =   7320
         Width           =   1215
      End
      Begin VB.Label Label27 
         Caption         =   "Send Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   736
         Top             =   6840
         Width           =   1095
      End
      Begin VB.Label Label28 
         Caption         =   "Sending Interval (ms) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   735
         Top             =   5160
         Width           =   1695
      End
      Begin VB.Label Label29 
         Caption         =   "Sending Data Length (bytes) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -74880
         TabIndex        =   734
         Top             =   5520
         Width           =   2295
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   28
         Left            =   -66000
         TabIndex        =   733
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   28
         Left            =   -65160
         TabIndex        =   732
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   28
         Left            =   -66000
         TabIndex        =   731
         Top             =   4320
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   28
         Left            =   -66000
         TabIndex        =   730
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   28
         Left            =   -66000
         TabIndex        =   729
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   24
         Left            =   -72240
         TabIndex        =   728
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   24
         Left            =   -71400
         TabIndex        =   727
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   24
         Left            =   -72240
         TabIndex        =   726
         Top             =   4320
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   24
         Left            =   -72240
         TabIndex        =   725
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   24
         Left            =   -72240
         TabIndex        =   724
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   21
         Left            =   -66000
         TabIndex        =   641
         Top             =   6840
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   21
         Left            =   -65160
         TabIndex        =   640
         Top             =   6120
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   21
         Left            =   -66000
         TabIndex        =   639
         Top             =   7800
         Width           =   615
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   -70320
         TabIndex        =   638
         Top             =   2760
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   21
         Left            =   -66000
         TabIndex        =   637
         Top             =   7320
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   21
         Left            =   -66000
         TabIndex        =   636
         Top             =   6360
         Width           =   735
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   18
         Left            =   -69120
         TabIndex        =   623
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   18
         Left            =   -69120
         TabIndex        =   622
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   18
         Left            =   -69120
         TabIndex        =   621
         Top             =   4320
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   18
         Left            =   -68280
         TabIndex        =   620
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   18
         Left            =   -69120
         TabIndex        =   619
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label4 
         Caption         =   "Port"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -69720
         TabIndex        =   618
         Top             =   4440
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label Label2 
         Caption         =   "IP"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -69960
         TabIndex        =   617
         Top             =   4440
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   19
         Left            =   -69120
         TabIndex        =   604
         Top             =   6360
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   19
         Left            =   -69120
         TabIndex        =   603
         Top             =   7320
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   19
         Left            =   -69120
         TabIndex        =   602
         Top             =   7800
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   19
         Left            =   -68280
         TabIndex        =   601
         Top             =   6120
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   19
         Left            =   -69120
         TabIndex        =   600
         Top             =   6840
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   17
         Left            =   -72240
         TabIndex        =   587
         Top             =   6360
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   17
         Left            =   -72240
         TabIndex        =   586
         Top             =   7320
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   17
         Left            =   -72240
         TabIndex        =   585
         Top             =   7800
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   17
         Left            =   -71400
         TabIndex        =   584
         Top             =   6120
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   17
         Left            =   -72240
         TabIndex        =   583
         Top             =   6840
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   435
         Index           =   16
         Left            =   -72240
         TabIndex        =   570
         Top             =   2880
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   16
         Left            =   -72240
         TabIndex        =   569
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label24 
         BackStyle       =   0  '透明
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   16
         Left            =   -71400
         TabIndex        =   568
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   16
         Left            =   -72240
         TabIndex        =   567
         Top             =   4320
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   16
         Left            =   -72240
         TabIndex        =   566
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   8
         Left            =   -71520
         TabIndex        =   554
         Top             =   7860
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   23
         Left            =   -62040
         TabIndex        =   553
         Top             =   6120
         Width           =   855
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   7
         Left            =   -71520
         TabIndex        =   552
         Top             =   4320
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label Label8 
         Caption         =   "Label8"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   15
         Index           =   2
         Left            =   -63360
         TabIndex        =   551
         Top             =   6480
         Width           =   15
      End
      Begin VB.Label Label5 
         Caption         =   "Sending Data Length (bytes) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   550
         Top             =   2040
         Width           =   2295
      End
      Begin VB.Label Label12 
         Caption         =   "Sending Interval (ms) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   549
         Top             =   1680
         Width           =   1695
      End
      Begin VB.Label Label15 
         Caption         =   "Send Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   548
         Top             =   3360
         Width           =   1095
      End
      Begin VB.Label Label16 
         Caption         =   "Receive Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   547
         Top             =   3840
         Width           =   1215
      End
      Begin VB.Label Label17 
         Caption         =   "Total Loss :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   546
         Top             =   4320
         Width           =   975
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   23
         Left            =   -62880
         TabIndex        =   545
         Top             =   6840
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   23
         Left            =   -62880
         TabIndex        =   544
         Top             =   6360
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   23
         Left            =   -62880
         TabIndex        =   543
         Top             =   7320
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   23
         Left            =   -62880
         TabIndex        =   542
         Top             =   7800
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   22
         Left            =   -62040
         TabIndex        =   541
         Top             =   2640
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   22
         Left            =   -62880
         TabIndex        =   540
         Top             =   4320
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   22
         Left            =   -62880
         TabIndex        =   539
         Top             =   3840
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   22
         Left            =   -62880
         TabIndex        =   538
         Top             =   2880
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   22
         Left            =   -62880
         TabIndex        =   537
         Top             =   3360
         Width           =   615
      End
      Begin VB.Label Label19 
         Caption         =   "SendTotal Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   536
         Top             =   2880
         Width           =   1335
      End
      Begin VB.Label Label23 
         Caption         =   "SendTotal Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   535
         Top             =   6360
         Width           =   1335
      End
      Begin VB.Label Label25 
         Caption         =   "Total Loss :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   534
         Top             =   7800
         Width           =   975
      End
      Begin VB.Label Label26 
         Caption         =   "Receive Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   533
         Top             =   7320
         Width           =   1215
      End
      Begin VB.Label Label27 
         Caption         =   "Send Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   532
         Top             =   6840
         Width           =   1095
      End
      Begin VB.Label Label28 
         Caption         =   "Sending Interval (ms) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   531
         Top             =   5160
         Width           =   1695
      End
      Begin VB.Label Label29 
         Caption         =   "Sending Data Length (bytes) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   -74880
         TabIndex        =   530
         Top             =   5520
         Width           =   2295
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   20
         Left            =   -66000
         TabIndex        =   529
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   20
         Left            =   -65160
         TabIndex        =   528
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   20
         Left            =   -66000
         TabIndex        =   527
         Top             =   4320
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   20
         Left            =   -66000
         TabIndex        =   526
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   20
         Left            =   -66000
         TabIndex        =   525
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   15
         Left            =   -62880
         TabIndex        =   425
         Top             =   6480
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   15
         Left            =   -62880
         TabIndex        =   424
         Top             =   7440
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   15
         Left            =   -62880
         TabIndex        =   423
         Top             =   7860
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   15
         Left            =   -62040
         TabIndex        =   422
         Top             =   6240
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   15
         Left            =   -62880
         TabIndex        =   421
         Top             =   6960
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   14
         Left            =   -62880
         TabIndex        =   420
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   14
         Left            =   -62880
         TabIndex        =   419
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   14
         Left            =   -62880
         TabIndex        =   418
         Top             =   4380
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   14
         Left            =   -62040
         TabIndex        =   417
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   14
         Left            =   -62880
         TabIndex        =   416
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   13
         Left            =   -66000
         TabIndex        =   415
         Top             =   6480
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   13
         Left            =   -66000
         TabIndex        =   414
         Top             =   7440
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   13
         Left            =   -66000
         TabIndex        =   413
         Top             =   7860
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   13
         Left            =   -65160
         TabIndex        =   412
         Top             =   6240
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   13
         Left            =   -66000
         TabIndex        =   411
         Top             =   6960
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   12
         Left            =   -66000
         TabIndex        =   410
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   12
         Left            =   -66000
         TabIndex        =   409
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   12
         Left            =   -66000
         TabIndex        =   408
         Top             =   4380
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   12
         Left            =   -65160
         TabIndex        =   407
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   12
         Left            =   -66000
         TabIndex        =   406
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   11
         Left            =   -69120
         TabIndex        =   405
         Top             =   6480
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   11
         Left            =   -69120
         TabIndex        =   404
         Top             =   7440
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   11
         Left            =   -69120
         TabIndex        =   403
         Top             =   7860
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   11
         Left            =   -68280
         TabIndex        =   402
         Top             =   6240
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   11
         Left            =   -69120
         TabIndex        =   401
         Top             =   6960
         Width           =   615
      End
      Begin VB.Label Label29 
         Caption         =   "Sending Data Length (bytes) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   400
         Top             =   5580
         Width           =   2295
      End
      Begin VB.Label Label28 
         Caption         =   "Sending Interval (ms) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   399
         Top             =   5220
         Width           =   1695
      End
      Begin VB.Label Label27 
         Caption         =   "Send Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   398
         Top             =   6900
         Width           =   1095
      End
      Begin VB.Label Label26 
         Caption         =   "Receive Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   397
         Top             =   7380
         Width           =   1215
      End
      Begin VB.Label Label25 
         Caption         =   "Total Loss :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   396
         Top             =   7860
         Width           =   975
      End
      Begin VB.Label Label23 
         Caption         =   "SendTotal Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   395
         Top             =   6420
         Width           =   1335
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   10
         Left            =   -69120
         TabIndex        =   394
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   10
         Left            =   -68280
         TabIndex        =   393
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   10
         Left            =   -69120
         TabIndex        =   392
         Top             =   4380
         Width           =   615
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   -70320
         TabIndex        =   391
         Top             =   2820
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   10
         Left            =   -69120
         TabIndex        =   390
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   10
         Left            =   -69120
         TabIndex        =   389
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label Label19 
         Caption         =   "SendTotal Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   388
         Top             =   2940
         Width           =   1335
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   9
         Left            =   -72240
         TabIndex        =   387
         Top             =   6900
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   9
         Left            =   -72240
         TabIndex        =   386
         Top             =   6420
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   9
         Left            =   -72240
         TabIndex        =   385
         Top             =   7380
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   9
         Left            =   -72240
         TabIndex        =   384
         Top             =   7860
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   9
         Left            =   -71400
         TabIndex        =   383
         Top             =   6180
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   8
         Left            =   -72240
         TabIndex        =   382
         Top             =   4380
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   8
         Left            =   -72240
         TabIndex        =   381
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   8
         Left            =   -72240
         TabIndex        =   380
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   8
         Left            =   -72240
         TabIndex        =   379
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label17 
         Caption         =   "Total Loss :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   378
         Top             =   4380
         Width           =   975
      End
      Begin VB.Label Label16 
         Caption         =   "Receive Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   377
         Top             =   3900
         Width           =   1215
      End
      Begin VB.Label Label15 
         Caption         =   "Send Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   376
         Top             =   3420
         Width           =   1095
      End
      Begin VB.Label Label12 
         Caption         =   "Sending Interval (ms) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   375
         Top             =   1740
         Width           =   1695
      End
      Begin VB.Label Label5 
         Caption         =   "Sending Data Length (bytes) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -74880
         TabIndex        =   374
         Top             =   2100
         Width           =   2295
      End
      Begin VB.Label Label8 
         Caption         =   "Label8"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   15
         Index           =   1
         Left            =   -72720
         TabIndex        =   373
         Top             =   3060
         Width           =   15
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   4
         Left            =   -71520
         TabIndex        =   372
         Top             =   4380
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   8
         Left            =   -71400
         TabIndex        =   371
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   -71520
         TabIndex        =   370
         Top             =   7920
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label Label4 
         Caption         =   "Port"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -66600
         TabIndex        =   369
         Top             =   7980
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label Label2 
         Caption         =   "IP"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   -66840
         TabIndex        =   368
         Top             =   7980
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.Label Label2 
         Caption         =   "IP"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   8160
         TabIndex        =   233
         Top             =   7980
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.Label Label4 
         Caption         =   "Port"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   8400
         TabIndex        =   232
         Top             =   7980
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   3480
         TabIndex        =   231
         Top             =   7920
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   3600
         TabIndex        =   230
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   3480
         TabIndex        =   229
         Top             =   4380
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label Label8 
         Caption         =   "Label8"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   15
         Index           =   0
         Left            =   2280
         TabIndex        =   228
         Top             =   3060
         Width           =   15
      End
      Begin VB.Label Label5 
         Caption         =   "Sending Data Length (bytes) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   227
         Top             =   2100
         Width           =   2295
      End
      Begin VB.Label Label12 
         Caption         =   "Sending Interval (ms) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   226
         Top             =   1740
         Width           =   1695
      End
      Begin VB.Label Label15 
         Caption         =   "Send Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   225
         Top             =   3420
         Width           =   1095
      End
      Begin VB.Label Label16 
         Caption         =   "Receive Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   224
         Top             =   3900
         Width           =   1215
      End
      Begin VB.Label Label17 
         Caption         =   "Total Loss :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   223
         Top             =   4380
         Width           =   975
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   2760
         TabIndex        =   222
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   0
         Left            =   2760
         TabIndex        =   221
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   2760
         TabIndex        =   220
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   2760
         TabIndex        =   219
         Top             =   4380
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   3600
         TabIndex        =   218
         Top             =   6180
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   2760
         TabIndex        =   217
         Top             =   7860
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   2760
         TabIndex        =   216
         Top             =   7380
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   1
         Left            =   2760
         TabIndex        =   215
         Top             =   6420
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   2760
         TabIndex        =   214
         Top             =   6900
         Width           =   615
      End
      Begin VB.Label Label19 
         Caption         =   "SendTotal Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   213
         Top             =   2940
         Width           =   1335
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   2
         Left            =   5880
         TabIndex        =   212
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   5880
         TabIndex        =   211
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label22 
         Caption         =   "bytes/sec"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   4680
         TabIndex        =   210
         Top             =   2820
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   5880
         TabIndex        =   209
         Top             =   4380
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   2
         Left            =   6720
         TabIndex        =   208
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   5880
         TabIndex        =   207
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label23 
         Caption         =   "SendTotal Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   206
         Top             =   6420
         Width           =   1335
      End
      Begin VB.Label Label25 
         Caption         =   "Total Loss :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   205
         Top             =   7860
         Width           =   975
      End
      Begin VB.Label Label26 
         Caption         =   "Receive Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   204
         Top             =   7380
         Width           =   1215
      End
      Begin VB.Label Label27 
         Caption         =   "Send Bytes :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   203
         Top             =   6900
         Width           =   1095
      End
      Begin VB.Label Label28 
         Caption         =   "Sending Interval (ms) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   202
         Top             =   5220
         Width           =   1695
      End
      Begin VB.Label Label29 
         Caption         =   "Sending Data Length (bytes) :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   201
         Top             =   5580
         Width           =   2295
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   5880
         TabIndex        =   200
         Top             =   6960
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   3
         Left            =   6720
         TabIndex        =   199
         Top             =   6240
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   5880
         TabIndex        =   198
         Top             =   7860
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   5880
         TabIndex        =   197
         Top             =   7440
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   3
         Left            =   5880
         TabIndex        =   196
         Top             =   6480
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   9000
         TabIndex        =   195
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   4
         Left            =   9840
         TabIndex        =   194
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   9000
         TabIndex        =   193
         Top             =   4380
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   9000
         TabIndex        =   192
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   4
         Left            =   9000
         TabIndex        =   191
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   9000
         TabIndex        =   190
         Top             =   6960
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   5
         Left            =   9840
         TabIndex        =   189
         Top             =   6240
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   9000
         TabIndex        =   188
         Top             =   7860
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   9000
         TabIndex        =   187
         Top             =   7440
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   5
         Left            =   9000
         TabIndex        =   186
         Top             =   6480
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   12120
         TabIndex        =   185
         Top             =   3420
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   6
         Left            =   12960
         TabIndex        =   184
         Top             =   2700
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   12120
         TabIndex        =   183
         Top             =   4380
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   12120
         TabIndex        =   182
         Top             =   3900
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   6
         Left            =   12120
         TabIndex        =   181
         Top             =   2940
         Width           =   735
      End
      Begin VB.Label LabSend 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   12120
         TabIndex        =   180
         Top             =   6960
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Packet No."
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   7
         Left            =   12960
         TabIndex        =   179
         Top             =   6240
         Width           =   855
      End
      Begin VB.Label LabLoss 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   12120
         TabIndex        =   178
         Top             =   7860
         Width           =   615
      End
      Begin VB.Label LabRcv 
         BackStyle       =   0  '透明
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   12120
         TabIndex        =   177
         Top             =   7440
         Width           =   615
      End
      Begin VB.Label Label20 
         Caption         =   "Rate: (bytes/sec)"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Index           =   7
         Left            =   12120
         TabIndex        =   176
         Top             =   6480
         Width           =   735
      End
   End
   Begin VB.CheckBox chk_stopsend 
      Caption         =   "Stop connecting (Type mismatch). Test again."
      ForeColor       =   &H000000FF&
      Height          =   195
      Left            =   9960
      MaskColor       =   &H00FFFFFF&
      TabIndex        =   40
      Top             =   480
      UseMaskColor    =   -1  'True
      Value           =   1  '核取
      Width           =   4335
   End
   Begin VB.Timer tmr_winsock 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   6600
      Top             =   120
   End
   Begin VB.CheckBox chk_pingpong 
      Caption         =   "PingPong"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   8760
      MaskColor       =   &H00FFFFFF&
      TabIndex        =   39
      Top             =   480
      UseMaskColor    =   -1  'True
      Value           =   1  '核取
      Width           =   1095
   End
   Begin VB.Timer tmr_subtract 
      Interval        =   500
      Left            =   1440
      Top             =   240
   End
   Begin VB.TextBox txtMappingModel 
      BackColor       =   &H00C0C0FF&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   10800
      TabIndex        =   38
      Top             =   240
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.TextBox TxtSendDataLentoall 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   270
      Left            =   4560
      TabIndex        =   35
      Text            =   "1400"
      Top             =   360
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntvaltoall 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   270
      Left            =   3960
      TabIndex        =   34
      Text            =   "1000"
      Top             =   0
      Width           =   855
   End
   Begin VB.CommandButton cmdComtesttotal 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Start to all"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7680
      Style           =   1  '圖片外觀
      TabIndex        =   33
      Top             =   120
      Width           =   1215
   End
   Begin VB.CommandButton cmdContotal 
      BackColor       =   &H00FFFF80&
      Caption         =   "Connect to all"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5760
      Style           =   1  '圖片外觀
      TabIndex        =   32
      Top             =   120
      Width           =   1815
   End
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   2400
      Top             =   240
   End
   Begin VB.Timer TmrRate 
      Interval        =   1000
      Left            =   2880
      Top             =   240
   End
   Begin VB.Timer Timer2 
      Interval        =   500
      Left            =   1920
      Top             =   240
   End
   Begin VB.CommandButton cmdClrList 
      BackColor       =   &H00C0C0FF&
      Caption         =   "Clear List"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   13080
      Style           =   1  '圖片外觀
      TabIndex        =   15
      Top             =   9600
      Width           =   975
   End
   Begin VB.OptionButton OptTcpUdp 
      Caption         =   "UDP"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   180
      Index           =   1
      Left            =   1920
      TabIndex        =   7
      Top             =   960
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.OptionButton OptTcpUdp 
      Caption         =   "TCP"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   180
      Index           =   0
      Left            =   1080
      TabIndex        =   6
      Top             =   960
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.ListBox List1 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00808080&
      Height          =   1950
      Left            =   0
      Style           =   1  '項目包含核取方塊
      TabIndex        =   0
      Top             =   9240
      Width           =   12975
   End
   Begin VB.OptionButton OptTestMode 
      Caption         =   "Loopback Test"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   225
      Index           =   0
      Left            =   120
      TabIndex        =   29
      Top             =   360
      Width           =   1695
   End
   Begin VB.OptionButton OptTestMode 
      Caption         =   "Cross Test"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   225
      Index           =   1
      Left            =   120
      TabIndex        =   30
      ToolTipText     =   "Switch to loopback mode (x to x+1)"
      Top             =   600
      Value           =   -1  'True
      Width           =   1455
   End
   Begin VB.CheckBox ChkXOnOff 
      Caption         =   "Don't Care Xon/off"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   4680
      TabIndex        =   31
      Top             =   960
      Value           =   1  '核取
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.CheckBox ChkRecdAck 
      Caption         =   "ACK Access Record"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2760
      TabIndex        =   21
      Top             =   960
      Visible         =   0   'False
      Width           =   1935
   End
   Begin VB.CommandButton CmdBrow 
      Caption         =   "..."
      BeginProperty Font 
         Name            =   "Arial Black"
         Size            =   9.75
         Charset         =   0
         Weight          =   900
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   11640
      TabIndex        =   23
      Top             =   9960
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.TextBox TxtLogFile 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   10200
      TabIndex        =   22
      Top             =   9960
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.CheckBox ChkRemote 
      Caption         =   "Show Remote IP"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   420
      Left            =   12240
      TabIndex        =   17
      Top             =   9120
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.TextBox txtData 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   9360
      TabIndex        =   3
      Text            =   "D1"
      Top             =   9120
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.CommandButton cmdSend 
      Caption         =   "&Send"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   9960
      TabIndex        =   1
      Top             =   9120
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.TextBox txtDaport 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8520
      TabIndex        =   2
      Text            =   "1"
      Top             =   9120
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.TextBox txtListCnt 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   270
      Left            =   8280
      TabIndex        =   8
      Top             =   9960
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.TextBox txtId2 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8280
      TabIndex        =   9
      Text            =   "0"
      Top             =   9480
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton cmdSend2 
      Caption         =   "S&end"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   12840
      TabIndex        =   10
      Top             =   9480
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.TextBox txtData2 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8760
      TabIndex        =   11
      Text            =   "\07\00\80\00\99\99R"
      Top             =   9480
      Visible         =   0   'False
      Width           =   3975
   End
   Begin VB.TextBox txtMsg 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   10560
      TabIndex        =   16
      Top             =   9120
      Visible         =   0   'False
      Width           =   1575
   End
   Begin VB.TextBox TxtID 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8160
      TabIndex        =   18
      Text            =   "0"
      Top             =   9120
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.TextBox TxtSubNode 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8880
      TabIndex        =   20
      Text            =   "01"
      Top             =   9120
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton CmdSaveList 
      Caption         =   "Save List"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   12120
      TabIndex        =   24
      Top             =   9960
      Visible         =   0   'False
      Width           =   1095
   End
   Begin VB.Label Label33 
      Caption         =   "Sending Data Length (bytes) to all :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   255
      Left            =   1920
      TabIndex        =   37
      Top             =   360
      Width           =   2655
   End
   Begin VB.Label Label32 
      Caption         =   "Sending Interval (ms) to all :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   255
      Left            =   1920
      TabIndex        =   36
      Top             =   0
      Width           =   2055
   End
   Begin VB.Label LabRunTime 
      Alignment       =   2  '置中對齊
      BorderStyle     =   1  '單線固定
      Caption         =   "0 Day 00:00:00"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000040&
      Height          =   375
      Left            =   12120
      TabIndex        =   28
      Top             =   0
      Width           =   1935
   End
   Begin VB.Label Label18 
      Caption         =   "Run Time :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000080FF&
      Height          =   375
      Left            =   10560
      TabIndex        =   27
      Top             =   0
      Width           =   1695
   End
   Begin VB.Label Label13 
      Caption         =   "Sending Data :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   6960
      TabIndex        =   25
      Top             =   960
      Visible         =   0   'False
      Width           =   1575
   End
   Begin VB.Label labTime 
      AutoSize        =   -1  'True
      Caption         =   "Label5"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   11.25
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   225
      Left            =   240
      TabIndex        =   5
      Top             =   0
      Width           =   675
   End
   Begin VB.Label Label14 
      Caption         =   "Log To File :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   9000
      TabIndex        =   26
      Top             =   9960
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Label Label10 
      Caption         =   "Subnode"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   13320
      TabIndex        =   19
      Top             =   9240
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.Label Label11 
      Caption         =   "IP :0/1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   8280
      TabIndex        =   14
      Top             =   9600
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.Label Label9 
      Caption         =   "DATA :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   8880
      TabIndex        =   13
      Top             =   9240
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label Label7 
      Caption         =   "(CCB[6]\subCmd\subNode+Data)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   9480
      TabIndex        =   12
      Top             =   9600
      Visible         =   0   'False
      Width           =   2775
   End
   Begin VB.Label Label3 
      Caption         =   "DATA :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   13320
      TabIndex        =   4
      Top             =   9120
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.Menu MnuSet 
      Caption         =   "&Setting"
      Visible         =   0   'False
      Begin VB.Menu MnuSetComp 
         Caption         =   "&Company Code"
      End
      Begin VB.Menu MnuAddId 
         Caption         =   "&Add ID"
      End
      Begin VB.Menu MnuSchedule 
         Caption         =   "Reader &Schedule"
      End
      Begin VB.Menu MnuGroup 
         Caption         =   "&Group"
      End
      Begin VB.Menu MnuHoliday 
         Caption         =   "&Holiday"
      End
      Begin VB.Menu MnuSetTime 
         Caption         =   "Current &Time"
      End
   End
   Begin VB.Menu MnuQuery 
      Caption         =   "&Query"
      Visible         =   0   'False
      Begin VB.Menu MnuQryComp 
         Caption         =   "&Company Code"
      End
      Begin VB.Menu MnuQryId 
         Caption         =   "Card &ID"
      End
      Begin VB.Menu MnuNULL1 
         Caption         =   "-"
      End
      Begin VB.Menu MnuQryRealT 
         Caption         =   "&Realtime Data"
      End
   End
End
Attribute VB_Name = "FrmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Update:
'  2004/08/12: update packet's sequential number to hex string

Option Explicit
'---------------------Evan Exchanged 2 value became 7 (and below) value (for COM3~COM8 of socket) 2007/10/22
Dim socket(31)         As Long
Dim StartDate         As String
Dim StartTime         As String

Dim LossCnt(31)        As String
Dim OldLoss(31)        As String
Dim BaseIntval(31)     As Integer

Dim RcvDataBuf(31)     As String
Dim RcvMode(31)        As Integer

Dim IntervalSecMax(31) As Long, IntervalSecCnt(31) As Long

'---------------------Evan Exchanged end 2007/10/22

Const RCV_PERIOD = 1            'When SendInterval>0, Send Data On Time
Const RCV_TIMEOUT = 2           'When SendInterval=0, Send Data Real Time

'Const LEN_PKET_HEAD = 5        'Packet Header:"AAA" + PketNo_Low(1) + PketNo_High(1)
Const LEN_PKET_HEAD = 7         'Packet Header:"AAA" + hex(PketNo)(4byte)
Const CODE_PKET_HEAD = "AAA"
Dim GetIP()         As String      '--------add by Elle
Dim COMs            As Integer        '--------add by Elle
Public iShow_Port   As Integer  '------add by Elle
Dim FFFF_getpkno    As Long       '-----add by Elle
Dim Send_data(31)    As String     '-----add by Elle
Dim Receive_data(31) As String  '-----add by Elle
Dim OK_flg(31)       As Boolean     '--------add by Elle
Dim multiple(31)     As Integer      '--------add by Elle
Dim tabidx        As Integer

Private Sub clean_arp() 'Evan added 2007/10/22

    Dim ip1    As String
    Dim ip2    As String
    Dim RetVal As Variant

    On Error Resume Next

    RetVal = Shell("arp -d", 0)
    '    'RetVal = Shell("arp -d 10.0.50.100", 3)
    '    'RetVal = Shell("arp -d 192.168.1.1", 3)
    '
    '    RetVal = Shell("arp -d " & ip1, 0)
    '    RetVal = Shell("arp -d " & ip2, 0)
    ''    RetVal = Shell("arp -d " & ip3, 0)
    ''    RetVal = Shell("arp -d " & ip4, 0)
    '    RetVal = Shell("arp -d 10.0.50.100", 0)
    '    RetVal = Shell("arp -d 192.168.1.1", 0)
    ''    RetVal = Shell("arp -d 10.0.50.102", 0)
    ''    RetVal = Shell("arp -d 10.0.50.103", 0)
End Sub

Private Sub CmdBrow_Click()
    
    ' MenuFlag = MENU_LOG_LIST
    ' LoadForm FrmFile

End Sub

Private Sub CmdClrCnt_Click(Index As Integer)  '------clear data
    Dim MsgStr As String
  
    '--- Log Clear Data ----
'    MsgStr = " " & "IP :" & " " & txtip(Index) & " Clear Counter " & Index + 1 & ": " & " Send=" & TxtCntSendTal(Index) & ", Send OK=" & TxtCntSend(Index) & ", Receive=" & TxtCntRcv(Index) & ", Total Loss=" & TxtCntLoss(Index)
'    lerror List1, MsgStr
    
    TxtCntSendTal(Index) = "0"
    TxtCntSend(Index) = "0"
    TxtCntRcv(Index) = "0"
    TxtCntLoss(Index) = "0"
    
End Sub

Private Sub cmdClrList_Click()
    List1.Clear
    txtListCnt = 0
    
End Sub

Private Sub cmdCnect_Click(Index As Integer)
    
    Dim MsgStr As String
    Const STR_CONNECT = "Connect"
    Const STR_DISCONNECT = "Disconnect"
    
    On Error GoTo ERRCMD
    
    clean_arp 'Evan added 2007/10/22
    
    If cmdCnect(Index).Caption = STR_CONNECT Then       'COnnect
        cmdCnect(Index).Caption = STR_DISCONNECT
        Winsock1(Index).Close
        TxtSendPketTal(Index).Text = "0" 'Evan added 2007/10/23
        TxtRcvPket(Index).Text = "0" 'Evan added 2007/10/23
        
        If 1 Or OptTcpUdp(0).Value = True Then
            Winsock1(Index).Protocol = sckTCPProtocol
            Winsock1(Index).RemoteHost = txtip(Index)
            Winsock1(Index).RemotePort = txtPort(Index)
            Winsock1(Index).LocalPort = txtLocalPort(Index)
            Winsock1(Index).Connect
        Else
            Winsock1(Index).Protocol = sckUDPProtocol
            Winsock1(Index).RemoteHost = txtip(Index)
            Winsock1(Index).RemotePort = txtPort(Index)
            Winsock1(Index).Bind txtLocalPort(Index)
        End If
        
        CmdClrCnt(Index).Value = True
        
    Else                'Disconnect

        If InStr(CmdSendBeg(Index).Caption, "Stop") > 0 Then      'On Sending,Stop It
            CmdSendBeg(Index).Value = True
        End If

        Winsock1(Index).Close
        cmdCnect(Index).Caption = STR_CONNECT
        txtLocalPort(Index) = 0
        CmdSendBeg(Index).Enabled = False
    
'        MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & Index + 1 & " Close OK!"
'        lerror List1, MsgStr
    End If
        
    '--- Maintain Enable OptTestMode ------
    If cmdCnect(0).Caption = STR_CONNECT And cmdCnect(1).Caption = STR_CONNECT And cmdCnect(2).Caption = STR_CONNECT And cmdCnect(3).Caption = STR_CONNECT And cmdCnect(4).Caption = STR_CONNECT And cmdCnect(5).Caption = STR_CONNECT And cmdCnect(6).Caption = STR_CONNECT And cmdCnect(7).Caption = STR_CONNECT _
    And cmdCnect(8).Caption = STR_CONNECT And cmdCnect(9).Caption = STR_CONNECT And cmdCnect(10).Caption = STR_CONNECT And cmdCnect(11).Caption = STR_CONNECT And cmdCnect(12).Caption = STR_CONNECT And cmdCnect(13).Caption = STR_CONNECT And cmdCnect(14).Caption = STR_CONNECT And cmdCnect(15).Caption = STR_CONNECT _
    And cmdCnect(16).Caption = STR_CONNECT And cmdCnect(17).Caption = STR_CONNECT And cmdCnect(18).Caption = STR_CONNECT And cmdCnect(19).Caption = STR_CONNECT And cmdCnect(20).Caption = STR_CONNECT And cmdCnect(21).Caption = STR_CONNECT And cmdCnect(22).Caption = STR_CONNECT And cmdCnect(23).Caption = STR_CONNECT _
    And cmdCnect(24).Caption = STR_CONNECT And cmdCnect(25).Caption = STR_CONNECT And cmdCnect(26).Caption = STR_CONNECT And cmdCnect(27).Caption = STR_CONNECT And cmdCnect(28).Caption = STR_CONNECT And cmdCnect(29).Caption = STR_CONNECT And cmdCnect(30).Caption = STR_CONNECT And cmdCnect(31).Caption = STR_CONNECT Then
        OptTestMode(0).Enabled = True
        OptTestMode(1).Enabled = True
    Else
        OptTestMode(0).Enabled = False
        OptTestMode(1).Enabled = False
    End If
    
    '    cmdCnect(Index).Enabled = False
    '    cmdDiscnect(Index).Enabled = True
    
    ' txtlocalport(Index) = Winsock1(Index).LocalPort

    Exit Sub

ERRCMD:
    MsgStr = " " & "IP :" & " " & txtip(Index) & "CmdCnect Err: " & Error
    lerror List1, MsgStr
End Sub

Private Sub cmdComtesttotal_Click() 'Evan added
    Dim conn_all, begin, even As Integer
    Dim send_flg As Boolean

    send_flg = True
    conn_all = COMs * UBound(GetIP)     '--------all connection
    even = 0

    If OptTestMode(1).Value = True Then    '-------cross loopback

        For begin = 0 To conn_all - 1

            If begin Mod 2 = 0 Then
                CmdSendBeg_Click (begin)
                
                If CmdSendBeg(begin).Caption = "Start " & begin + 1 Then
                    send_flg = False
                End If
            End If

        Next begin

    Else                                   '---------com loopback

        For begin = 0 To conn_all - 1
            CmdSendBeg_Click (begin)

            If CmdSendBeg(begin).Caption = "Start " & begin + 1 Then
                send_flg = False
            End If

        Next begin

    End If

    cmdContotal.Enabled = False
    TxtSendIntvaltoall.Enabled = False
    TxtSendDataLentoall.Enabled = False
    OptTestMode(0).Enabled = False
    OptTestMode(1).Enabled = False
    cmdComtesttotal.Caption = "Stop to all"

    If send_flg = False Then
        cmdComtesttotal.Caption = "Start to all"
        cmdContotal.Enabled = True
        TxtSendIntvaltoall.Enabled = True
        TxtSendDataLentoall.Enabled = True
        OptTestMode(0).Enabled = True
        OptTestMode(1).Enabled = True
        Exit Sub
    End If
End Sub

Private Sub cmdContotal_Click() 'Evan added 2007/10/22
    Dim conn_all, begin As Integer
    Dim conn_fail_flg, conn_close_flg As Boolean
    Dim MsgStr As String
    Const STR_CONNECT = "Connect"
    Const STR_DISCONNECT = "Disconnect"
    conn_fail_flg = False
    conn_close_flg = False
    conn_all = COMs * UBound(GetIP)     '--------all connection
    'conn_all = COMs * IP_num

    For begin = 0 To conn_all - 1

        If cmdCnect(begin).Caption = STR_CONNECT Then       'COnnect
            cmdCnect(begin).Caption = STR_DISCONNECT
            TxtSendPketTal(begin).Text = "0" 'Evan added 2007/10/23
            TxtRcvPket(begin).Text = "0" 'Evan added 2007/10/23
            Winsock1(begin).Protocol = sckTCPProtocol
            Winsock1(begin).RemoteHost = txtip(begin)
            Winsock1(begin).RemotePort = txtPort(begin)
            Winsock1(begin).LocalPort = txtLocalPort(begin)
            Winsock1(begin).Connect
            CmdClrCnt(begin).Value = True
        
        Else                'Disconnect

            If InStr(CmdSendBeg(begin).Caption, "Stop") > 0 Then      'On Sending,Stop It
                CmdSendBeg(begin).Value = True
            End If

            Winsock1(begin).Close
            cmdCnect(begin).Caption = STR_CONNECT
            txtLocalPort(begin) = 0
            CmdSendBeg(begin).Enabled = False
        
            cmdContotal.Caption = "Connect to all"
            cmdComtesttotal.Enabled = False

'            MsgStr = " " & "IP :" & " " & txtip(begin) & " COM " & begin + 1 & " Close OK!"
'            lerror List1, MsgStr
        
        End If

    Next begin

    tmr_winsock.Enabled = True
    tmr_winsock.Interval = 1000

    Dim i As Integer
    If OptTestMode(1).Value = True Then
        For i = 3 To 31 Step 2
            CmdSendBeg(i).Visible = False
        Next
'        CmdSendBeg(3).Visible = False
'        CmdSendBeg(5).Visible = False
'        CmdSendBeg(7).Visible = False
    Else
        For i = 1 To 31 Step 2
            CmdSendBeg(i).Visible = True
        Next
'        CmdSendBeg(1).Visible = True
'        CmdSendBeg(3).Visible = True
'        CmdSendBeg(5).Visible = True
'        CmdSendBeg(7).Visible = True
    End If
End Sub

Private Sub cmdListen_Click()
    Winsock1(1).LocalPort = txtPort(1)
    Winsock1(1).Listen
    txtLocalPort(1) = Winsock1(1).LocalPort
    
End Sub

Private Sub CmdSaveList_Click()
    Dim MsgStr As String, tmpstr As String, op As String
    Dim i      As Integer, Index As Integer, lens As Integer
    
    For i = 0 To List1.ListCount - 1
        op = List1.List(i)
        Index = Left(op, 1)
        op = Mid(op, 5)
        'head = Left(List1.Text, 4)
        'data = Mid(List1.Text, 29)
        lens = unldump(op, tmpstr)
        'txtMsg = head & retstr
        MsgStr = " " & "IP :" & " " & txtip(Index) & Index & ": " & tmpstr & "--" & op
        lerror2 TxtLogFile, MsgStr
    Next

End Sub

Private Sub cmdSend_Click()
    Dim data() As Byte
    Dim str1   As String, addr As String
    Dim Index  As Integer, datalen As Integer
    Dim ret    As Integer
    
    str1 = "\63\" & Right("0" & TxtSubNode, 2) & txtData
    datalen = Len(str1)
    ReDim data(datalen)
    datalen = HexIpB(str1, data(), 0)
    addr = txtDaport
    Index = Val(TxtID)
    '    ret = SendDapData2(Winsock1(Index), addr, Data(), datalen + 1) '+1 include 0
    ret = SendDapData0(Winsock1(Index), addr, data(), datalen) '+1 include 0
    
    'Winsock1(Index).SendData str1
    'Timer2.Enabled = True

End Sub

Private Sub cmdSend2_Click()
    Dim data() As Byte
    Dim str1   As String, addr As String
    Dim Index  As Integer, datalen As Integer
    Dim ret    As Integer
    
    On Error Resume Next
    
    str1 = txtData2
    datalen = Len(str1)
    ReDim data(datalen)
    datalen = HexIpB(str1, data(), 0)
    ReDim Preserve data(datalen - 1)
    '    addr = txtDaport2
    Index = Val(txtId2)
    '    ret = SendDapData2(Winsock1(Index), addr, Data(), datalen + 1) '+1 include 0
    'ret = SendDapData0(Winsock1(Index), addr, Data(), datalen) '+1 include 0
    Winsock1(Index).SendData data
    
End Sub

Private Sub CmdSendBeg_Click(Index As Integer)
    Const STR_START = "Start "
    Const STR_STOP = "Stop "
    Dim MsgStr   As String
    Dim Interval As Long, datalen As Integer, tmpLen As Integer
    Dim data()   As Byte
    Dim PketNo   As Long
    
    On Error GoTo ERRCMD
    
    If InStr(CmdSendBeg(Index).Caption, STR_START) > 0 Then      'START
'        MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & Index + 1 & " Send Start: Interval=" & TxtSendIntval(Index) & ", DataLen=" & TxtSendDataLen(Index)
        CmdSendBeg(Index).Caption = STR_STOP & Index + 1
        
        Interval = Val(TxtSendIntval(Index))

        If Interval = 0 Then                'Wait Time Out
            RcvMode(Index) = RCV_TIMEOUT
            Interval = 3000                 'Wait 3000ms, Check Loss
            RcvDataBuf(Index) = TxtSendData(Index)
        Else                                'Send On time
            RcvMode(Index) = RCV_PERIOD
        End If
        
        If Interval > 30000 Then
            IntervalSecMax(Index) = Interval / 1000
            IntervalSecCnt(Index) = 1
            Interval = 1000
        Else
            IntervalSecMax(Index) = 0
        End If
        
        TmrSend(Index).Interval = Interval
        
        TmrSend(Index).Enabled = True
                
        'TmrRate.Enabled = True
        TxtSendIntval(Index).Enabled = False
        TxtSendDataLen(Index).Enabled = False
        TxtSendData(Index).Enabled = False
        
        'if opttestmode(0).Value= then
        cmdCnect(Index).Enabled = False
        
        '        '---------below add by Elle-------------
        '        If OptTestMode(1).Value = True Then    '--------For Cross Test
        '            cmdCnect(Index + 1).Enabled = False
        '        End If
        '        '---------upper add by Elle-------------
        
        If RcvMode(Index) = RCV_TIMEOUT Then
            WSendData Index, TxtSendData(Index)
            RcvDataBuf(Index) = ""
        End If

    Else
        '--- Log Rate Data ----
        MsgStr = " " & "IP :" & " " & txtip(Index) & " Traffic " & Index + 1 & ": " & " Send=" & LabSend(Index) & ", Receive=" & LabRcv(Index) & ", Loss=" & LabLoss(Index)
        lerror List1, MsgStr
        
        MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & Index + 1 & " Send Stop:  Send=" & TxtCntSendTal(Index) & ", Send OK=" & TxtCntSend(Index) & ", Receive=" & TxtCntRcv(Index) & ", Total Loss=" & TxtCntLoss(Index) & ", SendPket=" & TxtSendPketTal(Index) & ", RcvPket=" & TxtRcvPket(Index)
        lerror List1, MsgStr
        
        CmdSendBeg(Index).Caption = STR_START & Index + 1
        TmrSend(Index).Enabled = False
        'TmrRate.Enabled = False
        TxtSendIntval(Index).Enabled = True
        TxtSendDataLen(Index).Enabled = True
        TxtSendData(Index).Enabled = True
        cmdCnect(Index).Enabled = True

        Exit Sub

    End If
    
'    lerror List1, MsgStr
    
    Exit Sub
    
ERRCMD:
    MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & Index + 1 & "   CmdSendBeg Err:   " & Error
    lerror List1, MsgStr

    Exit Sub

    Resume

End Sub

Sub WSendData(Index As Integer, DataStr As String)
    Dim PketNo  As Long
    Dim datalen As Integer, tmpLen As Integer
    Dim data()  As Byte
    Dim tmpstr  As String
    
    PketNo = TxtSendPketTal(Index) + 1
    'If PketNo > 65535 Then PketNo = 0      '2 bytes for PketNo
    PketNo = PketNo And &HFFFF             '2 bytes for PketNo, update to hex string
    
    TxtSendPketTal(Index) = PketNo
            
    datalen = Len(TxtSendData(Index)) + LEN_PKET_HEAD
    ReDim data(datalen - 1)
    tmpLen = HexIpB(TxtSendData(Index), data(), LEN_PKET_HEAD)
    tmpLen = HexIpB(CODE_PKET_HEAD, data(), 0)
   
    'data(3) = PketNo Mod 256          'PketNo_Low
    'data(4) = PketNo \ 256            'PketNo_High
    tmpstr = Right(Hex(&H10000 + PketNo), 4)          'update to hex string
    data(3) = Asc(Mid(tmpstr, 1, 1))  'PketNo_High
    data(4) = Asc(Mid(tmpstr, 2, 1))
    data(5) = Asc(Mid(tmpstr, 3, 1))
    data(6) = Asc(Mid(tmpstr, 4, 1))
    
    'Debug.Print "PketNo=" & PketNo

    '------------below add by Elle (for pingpong)-----------------
    Send_data(Index) = CODE_PKET_HEAD & tmpstr & DataStr
    '------------upper add by Elle (for pingpong)-----------------

    Winsock1(Index).SendData data
    
    TxtCntSendTal(Index) = TxtCntSendTal(Index) + datalen
    iTx(Index) = iTx(Index) + datalen    '------------add by Elle
    iLoss(Index) = iTx(Index) - iRx(Index)   '------------add by Elle

End Sub

Private Sub Command2_Click()
    MsgBox2 " Send=" & TxtCntSendTal(0) & ", Send OK=" & TxtCntSend(0) & ", Receive=" & TxtCntRcv(0) & ", Total Loss=" & TxtCntLoss(0)
         
    CmdSendBeg_Click (0)
    cmdCnect_Click (0)
    cmdCnect_Click (0)
    CmdSendBeg_Click (0)
End Sub

Private Sub Form_Load()
'    FrmMain.Caption = txtip(0).Text
    ''''''''''''''''''''''''''''''''''''''''''''''added below for read model at 2008/11/28
    Dim FileNo
    Dim str, Amount(2) As String
    Dim content   As String
    Dim intip, intcom, node, intport, com_16, com_16add As Integer
    Dim close_conn, disable_conn As Integer
    Dim i As Integer
    
    FileNo = FreeFile()
    Open App.Path & "\setting.txt" For Input As #FileNo

    i = 0
    While Not EOF(FileNo)
        Line Input #FileNo, str
        Amount(i) = str
        i = i + 1
'        txtMappingModel.Text = strString
    Wend
    Close #FileNo

    '----------------------below add by Elle----------------------------
    On Error GoTo ErrorHandle
    
    If OptTestMode(0).Value = True Then      '---------------------use color to know which mode(com loopback / cross loopback)
'        Me.Caption = Me.Caption & " (V" & App.Major & "." & App.Minor & ")" & " Standard --- COM Loopback"
        FrmMain.BackColor = &HFFFFC0
        labTime.BackColor = &HFFFFC0
        Label32.BackColor = &HFFFFC0
        Label33.BackColor = &HFFFFC0
        Label18.BackColor = &HFFFFC0
        OptTestMode(0).BackColor = &HFFFFC0
        OptTestMode(1).BackColor = &HFFFFC0
        chk_pingpong.BackColor = &HFFFFC0
        chk_stopsend.BackColor = &HFFFFC0
    ElseIf OptTestMode(1).Value = True Then
'        Me.Caption = Me.Caption & " (V" & App.Major & "." & App.Minor & ")" & " Standard --- Cross Loopback"
        FrmMain.BackColor = &HC0E0FF
        labTime.BackColor = &HC0E0FF
        Label32.BackColor = &HC0E0FF
        Label33.BackColor = &HC0E0FF
        Label18.BackColor = &HC0E0FF
        OptTestMode(0).BackColor = &HC0E0FF
        OptTestMode(1).BackColor = &HC0E0FF
        chk_pingpong.BackColor = &HC0E0FF
        chk_stopsend.BackColor = &HC0E0FF
    End If
   
    '-------------------add for atc----------------------------------------------------------
'    If strString = "GW21S-256" Or strString = "GW21S-MEGA" Or strString = "CE5101-16" Then
'        COMs = 1            '----------for 1 ports
'    ElseIf strString = "SE5302" Or strString = "C1502" Or strString = "SE1402" Or strString = "SE7404" Or InStr(strString, "SE7402") Or strString = "SE7202" Or strString = "SE102" Then
'        COMs = 2            '-----------for 2 ports
'    ElseIf strString = "GW2204S-MEGAV2" Or strString = "SE5404" Or InStr(strString, "SE1504") Or strString = "SE7404-M1" Then
'        COMs = 4            '------------for 4 ports
'    ElseIf strString = "GW2208S-MEGAV2" Then
'        COMs = 8            '------------for 8 ports
'    ElseIf strString = "SE5016" Or strString = "SE5116" Or strString = "SE5116 (for 2 LAN)" Or strString = "SE5516-IDE" Or strString = "MB5416" Then
'        COMs = 8     '--------for 16 ports
'    ElseIf strString = "SE7416" Or InStr(strString, "SE7816") Then
'        COMs = 8            '------------for 32 ports
'    Else
'        MsgBox ("不支援的型號")
'    End If

   If Amount(0) = "1" Then
        COMs = 1            '----------for 1 ports
    ElseIf Amount(0) = "2" Then
        COMs = 2            '-----------for 2 ports
    ElseIf Amount(0) = "4" Then
        COMs = 4            '------------for 4 ports
    ElseIf Amount(0) = "8" Then
        COMs = 8            '------------for 8 ports
    ElseIf Amount(0) = "16" Then
        COMs = 16            '--------for 16 ports
    ElseIf Amount(0) = "24" Then
        COMs = 24            '--------for 24 ports
    ElseIf Amount(0) = "32" Then
        COMs = 32            '------------for 32 ports
    Else
        MsgBox ("不支援的型號")
    End If

    If Amount(1) = "" Then        '-------avoid that user open this exe directly
        Dim test As String
        test = "-10.0.50.100"       '-----------assign default IP
        GetIP = Split(test, "-")
    Else
        GetIP = Split(Amount(1), "-")
    End If

    node = 0      '--------initual
    
    If UBound(GetIP) * Val(COMs) < 32 Then      '-----------enable /disable object

        For disable_conn = 31 To UBound(GetIP) * Val(COMs) Step -1
            txtip(disable_conn).Visible = False
            txtPort(disable_conn).Visible = False
            cmdCnect(disable_conn).Visible = False
            TxtSendIntval(disable_conn).Visible = False
            TxtSendDataLen(disable_conn).Visible = False
            CmdSendBeg(disable_conn).Visible = False
            TxtCntSendTal(disable_conn).Visible = False
            TxtCntSend(disable_conn).Visible = False
            TxtCntRcv(disable_conn).Visible = False
            TxtCntLoss(disable_conn).Visible = False
            Label20(disable_conn).Visible = False
            LabSend(disable_conn).Visible = False
            LabRcv(disable_conn).Visible = False
            LabLoss(disable_conn).Visible = False
            Label24(disable_conn).Visible = False
            TxtSendPketTal(disable_conn).Visible = False
            TxtSendPket(disable_conn).Visible = False
            TxtRcvPket(disable_conn).Visible = False
        Next disable_conn
                    
        '----------------------------below (hide useless object)------------------------
        If UBound(GetIP) * Val(COMs) = 1 Or UBound(GetIP) * Val(COMs) = 2 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
            Label38.Visible = False
            txtStatus1617.Visible = False
            Label37.Visible = False
            txtStatus1415.Visible = False
            Label36.Visible = False
            txtStatus1213.Visible = False
            Label35.Visible = False
            txtStatus1011.Visible = False
            Label34.Visible = False
            txtStatus89.Visible = False
            Label31.Visible = False
            txtStatus67.Visible = False
            Label30.Visible = False
            txtStatus45.Visible = False
            Label21.Visible = False
            txtStatus23.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 3 Or UBound(GetIP) * Val(COMs) = 4 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
            Label38.Visible = False
            txtStatus1617.Visible = False
            Label37.Visible = False
            txtStatus1415.Visible = False
            Label36.Visible = False
            txtStatus1213.Visible = False
            Label35.Visible = False
            txtStatus1011.Visible = False
            Label34.Visible = False
            txtStatus89.Visible = False
            Label31.Visible = False
            txtStatus67.Visible = False
            Label30.Visible = False
            txtStatus45.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 5 Or UBound(GetIP) * Val(COMs) = 6 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
            Label38.Visible = False
            txtStatus1617.Visible = False
            Label37.Visible = False
            txtStatus1415.Visible = False
            Label36.Visible = False
            txtStatus1213.Visible = False
            Label35.Visible = False
            txtStatus1011.Visible = False
            Label34.Visible = False
            txtStatus89.Visible = False
            Label31.Visible = False
            txtStatus67.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 7 Or UBound(GetIP) * Val(COMs) = 8 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
            Label38.Visible = False
            txtStatus1617.Visible = False
            Label37.Visible = False
            txtStatus1415.Visible = False
            Label36.Visible = False
            txtStatus1213.Visible = False
            Label35.Visible = False
            txtStatus1011.Visible = False
            Label34.Visible = False
            txtStatus89.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 9 Or UBound(GetIP) * Val(COMs) = 10 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
            Label38.Visible = False
            txtStatus1617.Visible = False
            Label37.Visible = False
            txtStatus1415.Visible = False
            Label36.Visible = False
            txtStatus1213.Visible = False
            Label35.Visible = False
            txtStatus1011.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 11 Or UBound(GetIP) * Val(COMs) = 12 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
            Label38.Visible = False
            txtStatus1617.Visible = False
            Label37.Visible = False
            txtStatus1415.Visible = False
            Label36.Visible = False
            txtStatus1213.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 13 Or UBound(GetIP) * Val(COMs) = 14 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
            Label38.Visible = False
            txtStatus1617.Visible = False
            Label37.Visible = False
            txtStatus1415.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 16 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
            Label38.Visible = False
            txtStatus1617.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 18 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
            Label39.Visible = False
            txtStatus1819.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 20 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
            Label40.Visible = False
            txtStatus2021.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 22 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
            Label41.Visible = False
            txtStatus2223.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 24 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
            Label42.Visible = False
            txtStatus2425.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 26 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
            Label43.Visible = False
            txtStatus2627.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 28 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
            Label44.Visible = False
            txtStatus2829.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 30 Then
            Label45.Visible = False
            txtStatus3031.Visible = False
        ElseIf UBound(GetIP) * Val(COMs) = 15 Or UBound(GetIP) * Val(COMs) = 32 Then
        End If
        '------------------------upper (hide useless object)---------------------------
    End If
                
    ' MsgBox "current model= " & strString
       
    For intip = 1 To UBound(GetIP)            '-------at first,GetIP(0)=" "
            For intcom = 0 + node To COMs - 1 + node      '---------assign IP
                txtip(intcom).Text = GetIP(intip)
            Next intcom
                    
            For intport = 0 + node To COMs - 1 + node     '--------assign Port
                txtPort(intport).Text = Amount(2) + intport - node  ' Amount(2) = 4660 or 8000
            Next intport
                
            node = node + Val(COMs)
    Next intip
                   
    If OptTestMode(1).Value = True Then        '--------user select "Cross Test" and hide COM2/4/6/8
        For i = 1 To 31 Step 2
            CmdSendBeg(i).Visible = False
        Next
'        CmdSendBeg(1).Visible = False
'        CmdSendBeg(3).Visible = False
'        CmdSendBeg(5).Visible = False
'        CmdSendBeg(7).Visible = False
'        CmdSendBeg(9).Visible = False
    Else
        For i = 1 To 31 Step 2
            CmdSendBeg(i).Visible = True
        Next
'        CmdSendBeg(1).Visible = True
'        CmdSendBeg(3).Visible = True
'        CmdSendBeg(5).Visible = True
'        CmdSendBeg(7).Visible = True
'        CmdSendBeg(9).Visible = True
    End If

    Call SendMessage(List1.hwnd, LB_SETHORIZONTALEXTENT, 2000, ByVal 0&)
    TxtLogFile = App.Path & "\" & Format(Date, "YYYYMMDD") & ".TXT"
    TxtLogFile.SelStart = Len(TxtLogFile)
        
    For i = 0 To 31 Step 1
            TxtSendDataLen_Change i
    Next
'    TxtSendDataLen_Change 0
'    TxtSendDataLen_Change 1
'    TxtSendDataLen_Change 2
'    TxtSendDataLen_Change 3
'    TxtSendDataLen_Change 4
'    TxtSendDataLen_Change 5
'    TxtSendDataLen_Change 6
'    TxtSendDataLen_Change 7
'    TxtSendDataLen_Change 8
'    TxtSendDataLen_Change 9
'    TxtSendDataLen_Change 10
'    TxtSendDataLen_Change 11
'    TxtSendDataLen_Change 12
'    TxtSendDataLen_Change 13
'    TxtSendDataLen_Change 14
'    TxtSendDataLen_Change 15
    
    StartDate = Date
    StartTime = Time

    FFFF_getpkno = 0 '------------test pkno add by Elle (test ok and then erase this )
    '--------------below add by Elle (ping pong)
    For i = 0 To 31 Step 1
        OK_flg(i) = True
    Next
'    OK_flg(0) = True
'    OK_flg(1) = True
'    OK_flg(2) = True
'    OK_flg(3) = True
'    OK_flg(4) = True
'    OK_flg(5) = True
'    OK_flg(6) = True
'    OK_flg(7) = True
'    OK_flg(8) = True
'    OK_flg(9) = True
'    OK_flg(10) = True
'    OK_flg(11) = True
'    OK_flg(12) = True
'    OK_flg(13) = True
'    OK_flg(14) = True
'    OK_flg(15) = True
    '-------------upper add by Elle (ping pong)

    SSTab1.TabCaption(0) = "1"
    SSTab1.TabCaption(1) = "2"
    SSTab1.TabCaption(2) = "3"
    SSTab1.TabCaption(3) = "4"
    SSTab1.Tab = 0  '程式執行時，指定顯示的分頁

    If Dir("Auto_Send") <> "" Then
        Call cmdContotal_Click
        Call cmdComtesttotal_Click
    End If
    
    Exit Sub
ErrorHandle:
    MsgBox "Form_Load= " & Error
 
End Sub

Private Sub Form_Unload(Cancel As Integer)
    
    End
    
End Sub

Private Sub List1_Click()
    Dim head   As String, data As String
    Dim retstr As String
    Dim lens   As Integer
    
    txtListCnt = List1.ListIndex + 1

    If List1.ListCount > 32000 Then
        List1.RemoveItem 0
    End If
    
    Exit Sub
    
    head = Left(List1.Text, 4)
    data = Mid(List1.Text, 29)
    lens = unldump(data, retstr)
    txtMsg = head & retstr
    List1.ToolTipText = List1.Text
    
End Sub

Private Sub MnuAddId_Click()
    
    'MenuFlag = CMD_ADD_ID
    'FrmMain.Enabled = False
    'LoadForm FrmSet
    
End Sub

Private Sub MnuGroup_Click()
    
    MenuFlag = CMD_SET_GROUP
    FrmMain.Enabled = False
    'LoadForm FrmSet

End Sub

Private Sub MnuHoliday_Click()
    
    MenuFlag = CMD_SET_HOLIDAY
    FrmMain.Enabled = False
    'LoadForm FrmSet

End Sub

Private Sub MnuQryComp_Click()

    MenuFlag = CMD_QRY_COMP
    FrmMain.Enabled = False
    ' LoadForm FrmSet

End Sub

Private Sub MnuQryId_Click()

    MenuFlag = CMD_QRY_ID
    FrmMain.Enabled = False
    ' LoadForm FrmSet
    
End Sub

Private Sub MnuQryRealT_Click()

    MenuFlag = CMD_GET_RECD
    FrmMain.Enabled = False
    'LoadForm FrmSet

End Sub

Private Sub MnuSchedule_Click()
    
    MenuFlag = CMD_SCHEDULE
    FrmMain.Enabled = False
    ' LoadForm FrmSet

End Sub

Private Sub MnuSetComp_Click()
    
    MenuFlag = CMD_ADD_COMP
    FrmMain.Enabled = False
    'LoadForm FrmSet

End Sub

Private Sub MnuSetTime_Click()
    Dim data() As Byte
    Dim str1   As String, TimeStr As String, tmpstr As String
    Dim addr   As String, DateStr As String
    Dim Index  As Integer, datalen As Integer
    Dim i      As Integer, ret As Integer, week As Integer
    Dim OkCnt  As Integer, ErrCnt As Integer, Cnt As Integer
    Dim Start  As Long, nowTime As Long, TimeoutFlag As Boolean
    
    FrmMain.MousePointer = vbHourglass
    
    '---  Send command ---------
    TimeoutFlag = False
    Cnt = 1
    'CMD: "D"+<Mode>1+<Date>9+<Time>6
    '<Mode>: 1 -> Query Time
    '        2 -> Set Current Time
    '<Date>: YYYYMMDDW
    '<Time>: HHMMSS
    '----  Get Time Zone -----------
    DateStr = Format(Date, "yyyymmdd")
    i = Format(Date, "w")
    week = i - 1

    If week = 0 Then week = 7
    DateStr = DateStr & Trim(str(week))
    TimeStr = Format(Time, "hhmmss")
    
    str1 = "\63\" & Right("0" & TxtSubNode, 2) & CMD_SET_TIME & "2" & DateStr & TimeStr
    datalen = Len(str1)
    ReDim data(datalen)
    datalen = HexIpB(str1, data(), 0)
    addr = FrmMain.txtDaport
    Index = Val(FrmMain.TxtID)
    ret = SendDapData0(FrmMain.Winsock1(Index), addr, data(), datalen)  '+1 include 0
        
    '----- Waitting Response ------------------
    AckFlag = False
    Start = Timer

    Do While (AckFlag = False)
        nowTime = Timer

        If nowTime < Start Then nowTime = nowTime + CNST_DAY_SEC
        If nowTime > (Start + CNST_TIMEOUT_ACC) Then    'timeout
            AckFlag = True
            TimeoutFlag = True
        End If
            
        DoEvents
    Loop

    '------ Record Result -----------------
    If TimeoutFlag Then         'timeout
        ErrCnt = ErrCnt + 1
        TimeoutFlag = False
    Else                        'Ack OK
        OkCnt = OkCnt + 1
    End If
        
    '---- Report Result ------------
    tmpstr = "Total: " & Cnt & ",  OK: " & OkCnt & ",   Err: " & ErrCnt
    MsgBox "Set Time: " & tmpstr
    'StatusBar1.Panels.Item(1) = tmpstr

    FrmMain.MousePointer = vbDefault

End Sub

Private Sub OptTestMode_Click(Index As Integer)
'    Me.Caption = ""
    If OptTestMode(0).Value = True Then      '---------------------use color to know which mode(com loopback / cross loopback)
'        Me.Caption = Me.Caption & " (V" & App.Major & "." & App.Minor & ")" & " Standard --- COM Loopback"
        FrmMain.BackColor = &HFFFFC0
        labTime.BackColor = &HFFFFC0
        Label32.BackColor = &HFFFFC0
        Label33.BackColor = &HFFFFC0
        Label18.BackColor = &HFFFFC0
        OptTestMode(0).BackColor = &HFFFFC0
        OptTestMode(1).BackColor = &HFFFFC0
        chk_pingpong.BackColor = &HFFFFC0
        chk_stopsend.BackColor = &HFFFFC0
    ElseIf OptTestMode(1).Value = True Then
'        Me.Caption = Me.Caption & " (V" & App.Major & "." & App.Minor & ")" & " Standard --- Cross Loopback"
        FrmMain.BackColor = &HC0E0FF
        labTime.BackColor = &HC0E0FF
        Label32.BackColor = &HC0E0FF
        Label33.BackColor = &HC0E0FF
        Label18.BackColor = &HC0E0FF
        OptTestMode(0).BackColor = &HC0E0FF
        OptTestMode(1).BackColor = &HC0E0FF
        chk_pingpong.BackColor = &HC0E0FF
        chk_stopsend.BackColor = &HC0E0FF
    End If
  
    Dim i As Integer
     If Index = 1 Then
        For i = 1 To 31 Step 2
            CmdSendBeg(i).Visible = False
        Next
    Else
        For i = 1 To 31 Step 2
            CmdSendBeg(i).Visible = True
        Next
    End If

End Sub

Private Sub Timer1_Timer()
    Dim tmpstr      As String
    Dim tmpstr23, tmpstr45, tmpstr67, tmpstr89, tmpstr1011, tmpstr1213, tmpstr1415, tmpstr1617, tmpstr1819, tmpstr2021, tmpstr2223, _
    tmpstr2425, tmpstr2627, tmpstr2829, tmpstr3031 As String
    Dim Index As Integer
    Static FileName As String
       
    On Error Resume Next
    
    labTime = Time$

    tmpstr = Winsock1(0).State & Chr(13) & Chr(10) '"    "
    tmpstr = tmpstr & Winsock1(1).State
    txtStatus01 = tmpstr
    tmpstr = Format(Date, "YYYYMMDD")
    If tmpstr <> FileName Then
        FileName = tmpstr
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Visible = True And Winsock1(0).State = 7 And Winsock1(1).State = 7 Then
        CmdSendBeg(0).Enabled = True
    End If
    
    tmpstr23 = Winsock1(2).State & Chr(13) & Chr(10) '"    "
    tmpstr23 = tmpstr23 & Winsock1(3).State
    txtStatus23 = tmpstr23
    tmpstr23 = Format(Date, "YYYYMMDD")
    If tmpstr23 <> FileName Then
        FileName = tmpstr23
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(2).State = 7 And Winsock1(3).State = 7 Then
        CmdSendBeg(2).Enabled = True
    End If
    
    tmpstr45 = Winsock1(4).State & Chr(13) & Chr(10) '"    "
    tmpstr45 = tmpstr45 & Winsock1(5).State
    txtStatus45 = tmpstr45
    tmpstr45 = Format(Date, "YYYYMMDD")
    If tmpstr45 <> FileName Then
        FileName = tmpstr45
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
        If OptTestMode(1).Value = True And Winsock1(4).State = 7 And Winsock1(5).State = 7 Then
        CmdSendBeg(4).Enabled = True
    End If
    
    tmpstr67 = Winsock1(6).State & Chr(13) & Chr(10) '"    "
    tmpstr67 = tmpstr67 & Winsock1(7).State
    txtStatus67 = tmpstr67
    tmpstr67 = Format(Date, "YYYYMMDD")
    If tmpstr67 <> FileName Then
        FileName = tmpstr67
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(6).State = 7 And Winsock1(7).State = 7 Then
        CmdSendBeg(6).Enabled = True
    End If
    
    tmpstr89 = Winsock1(8).State & Chr(13) & Chr(10) '"    "
    tmpstr89 = tmpstr89 & Winsock1(9).State
    txtStatus89 = tmpstr89
    tmpstr89 = Format(Date, "YYYYMMDD")
    If tmpstr89 <> FileName Then
        FileName = tmpstr89
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(8).State = 7 And Winsock1(9).State = 7 Then
        CmdSendBeg(8).Enabled = True
    End If
    
    tmpstr1011 = Winsock1(10).State & Chr(13) & Chr(10) '"    "
    tmpstr1011 = tmpstr1011 & Winsock1(11).State
    txtStatus1011 = tmpstr1011
    tmpstr1011 = Format(Date, "YYYYMMDD")
    If tmpstr1011 <> FileName Then
        FileName = tmpstr1011
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(10).State = 7 And Winsock1(11).State = 7 Then
        CmdSendBeg(10).Enabled = True
    End If
    
    tmpstr1213 = Winsock1(12).State & Chr(13) & Chr(10) '"    "
    tmpstr1213 = tmpstr1213 & Winsock1(13).State
    txtStatus1213 = tmpstr1213
    tmpstr1213 = Format(Date, "YYYYMMDD")
    If tmpstr1213 <> FileName Then
        FileName = tmpstr1213
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(12).State = 7 And Winsock1(13).State = 7 Then
        CmdSendBeg(12).Enabled = True
    End If
    
    tmpstr1415 = Winsock1(14).State & Chr(13) & Chr(10) '"    "
    tmpstr1415 = tmpstr1415 & Winsock1(15).State
    txtStatus1415 = tmpstr1415
    tmpstr1415 = Format(Date, "YYYYMMDD")
    If tmpstr1415 <> FileName Then
        FileName = tmpstr1415
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(14).State = 7 And Winsock1(15).State = 7 Then
        CmdSendBeg(14).Enabled = True
    End If
    
    tmpstr1617 = Winsock1(16).State & Chr(13) & Chr(10) '"    "
    tmpstr1617 = tmpstr1617 & Winsock1(17).State
    txtStatus1617 = tmpstr1617
    tmpstr1617 = Format(Date, "YYYYMMDD")
    If tmpstr1617 <> FileName Then
        FileName = tmpstr1617
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(16).State = 7 And Winsock1(17).State = 7 Then
        CmdSendBeg(16).Enabled = True
    End If
    
    tmpstr1819 = Winsock1(18).State & Chr(13) & Chr(10) '"    "
    tmpstr1819 = tmpstr1819 & Winsock1(19).State
    txtStatus1819 = tmpstr1819
    tmpstr1819 = Format(Date, "YYYYMMDD")
    If tmpstr1819 <> FileName Then
        FileName = tmpstr1819
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(18).State = 7 And Winsock1(19).State = 7 Then
        CmdSendBeg(18).Enabled = True
    End If
    
    tmpstr2021 = Winsock1(20).State & Chr(13) & Chr(10) '"    "
    tmpstr2021 = tmpstr2021 & Winsock1(21).State
    txtStatus2021 = tmpstr2021
    tmpstr2021 = Format(Date, "YYYYMMDD")
    If tmpstr2021 <> FileName Then
        FileName = tmpstr2021
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(20).State = 7 And Winsock1(21).State = 7 Then
        CmdSendBeg(20).Enabled = True
    End If
    
    tmpstr2223 = Winsock1(22).State & Chr(13) & Chr(10) '"    "
    tmpstr2223 = tmpstr2223 & Winsock1(23).State
    txtStatus2223 = tmpstr2223
    tmpstr2223 = Format(Date, "YYYYMMDD")
    If tmpstr2223 <> FileName Then
        FileName = tmpstr2223
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(22).State = 7 And Winsock1(23).State = 7 Then
        CmdSendBeg(22).Enabled = True
    End If
    
    tmpstr2425 = Winsock1(24).State & Chr(13) & Chr(10) '"    "
    tmpstr2425 = tmpstr2425 & Winsock1(25).State
    txtStatus2425 = tmpstr2425
    tmpstr2425 = Format(Date, "YYYYMMDD")
    If tmpstr2425 <> FileName Then
        FileName = tmpstr2425
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(24).State = 7 And Winsock1(25).State = 7 Then
        CmdSendBeg(24).Enabled = True
    End If
    
    tmpstr2627 = Winsock1(26).State & Chr(13) & Chr(10) '"    "
    tmpstr2627 = tmpstr2627 & Winsock1(27).State
    txtStatus2627 = tmpstr2627
    tmpstr2627 = Format(Date, "YYYYMMDD")
    If tmpstr2627 <> FileName Then
        FileName = tmpstr2627
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(26).State = 7 And Winsock1(27).State = 7 Then
        CmdSendBeg(26).Enabled = True
    End If
    
    tmpstr2829 = Winsock1(28).State & Chr(13) & Chr(10) '"    "
    tmpstr2829 = tmpstr2829 & Winsock1(29).State
    txtStatus2829 = tmpstr2829
    tmpstr2829 = Format(Date, "YYYYMMDD")
    If tmpstr2829 <> FileName Then
        FileName = tmpstr2829
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(28).State = 7 And Winsock1(29).State = 7 Then
        CmdSendBeg(28).Enabled = True
    End If
    
    tmpstr3031 = Winsock1(30).State & Chr(13) & Chr(10) '"    "
    tmpstr3031 = tmpstr3031 & Winsock1(31).State
    txtStatus3031 = tmpstr3031
    tmpstr3031 = Format(Date, "YYYYMMDD")
    If tmpstr3031 <> FileName Then
        FileName = tmpstr3031
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
    If OptTestMode(1).Value = True And Winsock1(30).State = 7 And Winsock1(31).State = 7 Then
        CmdSendBeg(30).Enabled = True
    End If
     
    Exit Sub
    
    With List1
        Index = .ListCount - 1

        If tmpstr <> .List(Index) Then
            .AddItem tmpstr
            .ListIndex = Index + 1
        End If

    End With
    
End Sub

Private Sub Timer2_Timer()
    Dim tmpstr As String, tmpVal As Integer
    Dim Hstr   As String, Mstr As String, Sstr As String, Dstr As String
  
    '  On Error GoTo ErrorHandle
  
    Label9.Caption = Format(Now, "yyyy/mm/dd hh:mm:ss")
  
    tmpVal = DateDiff("d", StartDate, Date)
    Dstr = IIf(tmpVal > 0, tmpVal, tmpVal)
    tmpVal = Hour(Time) - Hour(StartTime)
    Hstr = Right("0" & IIf(tmpVal >= 0, tmpVal, 24 + tmpVal), 2)
    tmpVal = Minute(Time) - Minute(StartTime)
    Mstr = Right("0" & IIf(tmpVal >= 0, tmpVal, 60 + tmpVal), 2)
    tmpVal = Second(Time) - Second(StartTime)
    Sstr = Right("0" & IIf(tmpVal >= 0, tmpVal, 60 + tmpVal), 2)
    LabRunTime = Dstr & " Day " & Hstr & ":" & Mstr & ":" & Sstr
  
    '  Exit Sub
    '
    'ErrorHandle:
    '  MsgBox "Timer2_Timer= " & Error
  
End Sub

Private Sub tmr_subtract_Timer()
    'MAX_COM_PORT
    Dim i As Integer

    For i = 0 To 31
        TxtCntLoss(i).Text = Val(TxtCntSend(i).Text) - Val(TxtCntRcv(i).Text)
    Next i

End Sub

Private Sub tmr_winsock_Timer()
    Dim conn_all, begin As Integer
    Dim conn_flg As Boolean
    conn_all = COMs * UBound(GetIP)     '--------all connection
    conn_flg = True

    For begin = 0 To conn_all - 1

        If Winsock1(begin).State = 7 Then
            conn_flg = True
        Else
            conn_flg = False
        End If

    Next begin

    If conn_flg = True Then
        cmdContotal.Caption = "Disconnect to all"
        cmdComtesttotal.Enabled = True
        tmr_winsock.Enabled = False
        tmr_winsock.Interval = 0
    Else
        cmdContotal.Caption = "Connect to all"
        cmdComtesttotal.Enabled = False
    End If

End Sub

Private Sub TmrRate_Timer()
    Static OldCntSend(32) As String
    Static OldCntRcv(32)  As String
    Static OldCntLoss(32) As String
    Static TimeCnt As Integer
    Dim tmpLong As Long, i As Integer, TestMode As Integer
    
    Const SAMPLE_TIME = 1        'Unit: Sec
    
    TimeCnt = TimeCnt + 1

    If TimeCnt < SAMPLE_TIME Then Exit Sub
    TimeCnt = 0
   
    '----------------below add by Elle-------------------------
    If OptTestMode(1).Value = True Then
        If Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 _
        And Winsock1(16).State = 7 And Winsock1(17).State = 7 And Winsock1(18).State = 7 And Winsock1(19).State = 7 _
        And Winsock1(20).State = 7 And Winsock1(21).State = 7 And Winsock1(22).State = 7 And Winsock1(23).State = 7 _
        And Winsock1(24).State = 7 And Winsock1(25).State = 7 And Winsock1(26).State = 7 And Winsock1(27).State = 7 _
        And Winsock1(28).State = 7 And Winsock1(29).State = 7 And Winsock1(30).State = 7 And Winsock1(31).State = 7 Then
            TestMode = 31
    ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 _
        And Winsock1(16).State = 7 And Winsock1(17).State = 7 And Winsock1(18).State = 7 And Winsock1(19).State = 7 _
        And Winsock1(20).State = 7 And Winsock1(21).State = 7 And Winsock1(22).State = 7 And Winsock1(23).State = 7 _
        And Winsock1(24).State = 7 And Winsock1(25).State = 7 And Winsock1(26).State = 7 And Winsock1(27).State = 7 _
        And Winsock1(28).State = 7 And Winsock1(29).State = 7 Then
            TestMode = 29
    ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 _
        And Winsock1(16).State = 7 And Winsock1(17).State = 7 And Winsock1(18).State = 7 And Winsock1(19).State = 7 _
        And Winsock1(20).State = 7 And Winsock1(21).State = 7 And Winsock1(22).State = 7 And Winsock1(23).State = 7 _
        And Winsock1(24).State = 7 And Winsock1(25).State = 7 And Winsock1(26).State = 7 And Winsock1(27).State = 7 Then
            TestMode = 27
    ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 _
        And Winsock1(16).State = 7 And Winsock1(17).State = 7 And Winsock1(18).State = 7 And Winsock1(19).State = 7 _
        And Winsock1(20).State = 7 And Winsock1(21).State = 7 And Winsock1(22).State = 7 And Winsock1(23).State = 7 _
        And Winsock1(24).State = 7 And Winsock1(25).State = 7 Then
            TestMode = 25
    ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 _
        And Winsock1(16).State = 7 And Winsock1(17).State = 7 And Winsock1(18).State = 7 And Winsock1(19).State = 7 _
        And Winsock1(20).State = 7 And Winsock1(21).State = 7 And Winsock1(22).State = 7 And Winsock1(23).State = 7 Then
            TestMode = 23
    ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 _
        And Winsock1(16).State = 7 And Winsock1(17).State = 7 And Winsock1(18).State = 7 And Winsock1(19).State = 7 _
        And Winsock1(20).State = 7 And Winsock1(21).State = 7 Then
            TestMode = 21
    ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 _
        And Winsock1(16).State = 7 And Winsock1(17).State = 7 And Winsock1(18).State = 7 And Winsock1(19).State = 7 Then
            TestMode = 19
    ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 _
        And Winsock1(16).State = 7 And Winsock1(17).State = 7 Then
            TestMode = 17
    ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 And Winsock1(14).State = 7 And Winsock1(15).State = 7 Then
            TestMode = 15
        ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 _
        And Winsock1(12).State = 7 And Winsock1(13).State = 7 Then
            TestMode = 13
        ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 And Winsock1(10).State = 7 And Winsock1(11).State = 7 Then
            TestMode = 11
        ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 _
        And Winsock1(8).State = 7 And Winsock1(9).State = 7 Then
            TestMode = 9
        ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 _
        And Winsock1(4).State = 7 And Winsock1(5).State = 7 And Winsock1(6).State = 7 And Winsock1(7).State = 7 Then
            TestMode = 7
        ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 And Winsock1(4).State = 7 And Winsock1(5).State = 7 Then
            TestMode = 5
        ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 And Winsock1(2).State = 7 And Winsock1(3).State = 7 Then
            TestMode = 3
        ElseIf Winsock1(0).State = 7 And Winsock1(1).State = 7 Then
            TestMode = 1
        End If

    Else
        TestMode = 31
    End If
    '----------------upper add by Elle-------------------------

    For i = 0 To TestMode

        '--- Initial Value -----
        If OldCntSend(i) = "" Then OldCntSend(i) = "0"
        If OldCntRcv(i) = "" Then OldCntRcv(i) = "0"
        If OldCntLoss(i) = "" Then OldCntLoss(i) = "0"
    
        '---- Check Send Rate ----------
        '    tmpLong = TxtCntSend - OldCntSend
        If Val(TxtSendIntval(i)) > 0 Then
            LabSend(i).Caption = (Val(TxtSendDataLen(i)) * 1000) / TxtSendIntval(i) 'tmpLong / SAMPLE_TIME
            'OldCntSend = TxtCntSend
        End If

        '---- Check Receive Rate ----------
        tmpLong = TxtCntRcv(i) - OldCntRcv(i)
        LabRcv(i).Caption = tmpLong / SAMPLE_TIME
        OldCntRcv(i) = TxtCntRcv(i)

        '---- Check Loss Rate ----------
        tmpLong = TxtCntLoss(i) - OldCntLoss(i)
        LabLoss(i).Caption = tmpLong / SAMPLE_TIME
        OldCntLoss(i) = TxtCntLoss(i)
    
    Next
    
End Sub

Private Sub TmrSend_Timer(Index As Integer)
    Dim MsgStr As String, ErrStr As String
    Static ErrMsg(31) As String
    
    On Error GoTo err99
    
    If IntervalSecMax(Index) Then
        IntervalSecCnt(Index) = IntervalSecCnt(Index) - 1

        If IntervalSecCnt(Index) Then

            Exit Sub

        Else
            IntervalSecCnt(Index) = IntervalSecMax(Index)
        End If
    End If
    
    ChcekLoss Index
    
    MsgStr = " " & "IP :" & " " & txtip(Index) & TxtSendData(Index)
    
    If RcvMode(Index) = RCV_TIMEOUT Then
        MsgStr = " " & "IP :" & " " & txtip(Index) & RcvDataBuf(Index)
        '''RcvDataBuf(Index) = ""
    Else
        '        WSendData Index, MsgStr
    End If

    '----------------------------below add by Elle (pingpong)-------------------------------
    Dim idx As Integer

    If chk_pingpong.Value = 1 Then      '-----------do ping pong
        multiple(Index) = multiple(Index) + 1   '------ No data then wait 5*interval

        If Winsock1(Index).State = 7 Then
                
            If OptTestMode(1).Value = True Then        '------------------------------For Corss LoopBack
                If Index Mod 2 = 0 Then
                    
                    If Send_data(Index) <> Receive_data(Index) Then
                        OK_flg(Index) = False

'                        If multiple(Index) <= 5 Then
                        If multiple(Index) <= 20 Then
                            '--------Don't send data anymore
                        Else
                            multiple(Index) = 1

                            If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10
                                WSendData Index, TxtSendData(Index)        '-------------Send data > &<
                            End If
                        End If
                    
                    Else
                        multiple(Index) = 1

                        If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10
                            WSendData Index, TxtSendData(Index)        '-------------Send data > &<
                        End If
                    End If
                    
                End If

            Else                                '-----------------------------------For Com LoopBack

                If Send_data(Index) <> Receive_data(Index) Then
                    OK_flg(Index) = False

'                    If multiple(Index) <= 5 Then
                    If multiple(Index) <= 20 Then
                        '--------Don't send data anymore
                    Else
                        multiple(Index) = 1

                        If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10
                            WSendData Index, TxtSendData(Index)        '-------------Send data > &<
                        End If
                    End If
                    
                Else
                    multiple(Index) = 1

                    If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10
                        WSendData Index, TxtSendData(Index)        '-------------Send data > &<
                    End If
                End If
            End If
                
        End If

    Else

        If OptTestMode(1).Value = True Then   '----------send data only 0,2,4,6
            If idx Mod 2 = 0 Then
                If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10
                    WSendData Index, TxtSendData(Index)        '-------------Send data > &<
                End If
            End If

        Else

            If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10
                WSendData Index, TxtSendData(Index)        '-------------Send data > &<
            End If
        End If
    End If

    '----------------------------upper add by Elle (pingpong)-------------------------------
      
    '    If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10  comma by Elle
    '    WSendData Index, TxtSendData(Index)        '-------------Send data > &<    comma by Elle
    '    End If                                     '------------------------comma by Elle
    
    'If OptTestMode(0).Value = False Then    'Cross Test
    'Winsock1(Index).SendData MsgStr
    'End If
    
    'TxtCntSendTal(Index) = TxtCntSendTal(Index) + Len(MsgStr)
    
    ErrMsg(Index) = ""
   
    'List1.AddItem "Send :" & Len(TxtSendData)
    
    Exit Sub
  
err99:

    ErrStr = Error

    If ErrMsg(Index) = ErrStr Then Exit Sub         'Only Log Error Message One Times
    ErrMsg(Index) = ErrStr

    MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & Index + 1 & "   TmrSend Error: " & ErrStr
    lerror List1, MsgStr

End Sub

Private Sub ChcekLoss(Index As Integer)
    Dim MsgStr As String
    Dim i      As Integer
    
    On Error GoTo err99
    
    'If OptTestMode(0).Value = True Then         'LoopBack Test
    '    Index = 1
    'Else
    '    Index = 0
    'End If
    
    TxtCntLoss(Index).Text = Val(TxtCntSend(Index).Text) - Val(TxtCntRcv(Index).Text)

    Exit Sub
    
    i = Index

    'For i = 0 To Index
    If TxtCntLoss(i) <> "0" Then
        If LossCnt(i) <> TxtCntLoss(i) Then
            MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & i + 1 & " Loss=" & TxtCntLoss(i) - LossCnt(i) & " Send=" & TxtCntSendTal(i) & ", Send OK=" & TxtCntSend(i) & ", Receive=" & TxtCntRcv(i) & ", Total Loss=" & TxtCntLoss(i)
            lerror List1, MsgStr
            LossCnt(i) = TxtCntLoss(i)
            OldLoss(i) = TxtCntLoss(i)
            
        End If

    Else
        LossCnt(i) = "0"

        '--- Check Full Data Receive --------
        If OldLoss(i) <> "0" Then
            MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & i + 1 & " Full Receive:" & " Send=" & TxtCntSendTal(i) & ", Send OK=" & TxtCntSend(i) & ", Receive=" & TxtCntRcv(i) & ", Total Loss=" & TxtCntLoss(i)
            lerror List1, MsgStr
            OldLoss(i) = TxtCntLoss(i)
        End If
    End If

    'Next
    Exit Sub
  
err99:
     
    MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & Index + 1 & " CheckLoss Error: " & Error
    lerror List1, MsgStr

End Sub

Private Sub TxtCntLoss_Change(Index As Integer)      '-------add by Elle
    Dim error_msg As String

    If Val(TxtCntLoss(Index).Text) > Val(TxtSendDataLen(Index).Text) Then
        error_msg = " " & "IP :" & " " & txtip(Index) & "  COM " & Index + 1 & "   Total Loss : " & TxtCntLoss(Index).Text
        lerror List1, error_msg
    End If

End Sub

Private Sub TxtCntLoss_KeyPress(Index As Integer, KeyAscii As Integer)
    KeyAscii = 0

End Sub

Private Sub TxtCntRcv_KeyPress(Index As Integer, KeyAscii As Integer)
    KeyAscii = 0

End Sub

Private Sub TxtCntSend_KeyPress(Index As Integer, KeyAscii As Integer)
    
    KeyAscii = 0
    
End Sub

Private Sub TxtCntSendTal_KeyPress(Index As Integer, KeyAscii As Integer)
    
    KeyAscii = 0

End Sub

Private Sub txtip_Change(Index As Integer)
'    FrmMain.Caption = txtip(0).Text
End Sub

Private Sub TxtRcvPket_KeyPress(Index As Integer, KeyAscii As Integer)
    
    KeyAscii = 0

End Sub

Private Sub TxtSendDataLen_Change(Index As Integer)
    'Const STR_DATA = "1234567890"
    Dim i      As Integer
    Dim tmpstr As String, MsgStr As String
    
    On Error GoTo ERRCMD
    
    tmpstr = ""

    For i = 1 To Val(TxtSendDataLen(Index)) - LEN_PKET_HEAD
        tmpstr = tmpstr & (i Mod 10)
    Next i
    
    TxtSendData(Index) = tmpstr    '------send content of data
    
    Exit Sub
    
ERRCMD:
    MsgStr = " " & "IP :" & " " & txtip(Index) & "TxtSendDataLen Err: " & Error
    lerror List1, MsgStr
End Sub

Private Sub TxtSendDataLentoall_Change()
    Dim i As Integer
    For i = 0 To 31
        TxtSendDataLen(i).Text = TxtSendDataLentoall.Text
    Next
End Sub

Private Sub TxtSendIntvaltoall_Change() 'Evan added
    Dim i As Integer
    For i = 0 To 31
        TxtSendIntval(i).Text = TxtSendIntvaltoall.Text
    Next
End Sub

Private Sub TxtSendPketTal_KeyPress(Index As Integer, KeyAscii As Integer)
    
    KeyAscii = 0

End Sub

Private Sub Winsock1_Close(Index As Integer)
    Dim MsgStr As String
    
    Winsock1(Index).Close
    MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & Index + 1 & " Close Complete!"
    lerror List1, MsgStr
    
    'Exit Sub
    
    If InStr(CmdSendBeg(Index).Caption, "Stop") > 0 Then
        CmdSendBeg(Index).Value = True
    End If
    
    CmdSendBeg(Index).Enabled = False
    
End Sub

Private Sub Winsock1_Connect(Index As Integer)
    Dim ret As Integer, optval As Integer
    Dim sck As Long, MsgStr As String, tmpstr As String
    
    iRx(Index) = 0    '------add by Elle
    iTx(Index) = 0    '------add by Elle
    iLoss(Index) = 0  '------add by Elle

    If OptTestMode(0).Value = True Then     'Loopback Test
        tmpstr = " Loopback Test "
    Else
        tmpstr = " Cross Test "
    End If
    
    txtLocalPort(Index) = Winsock1(Index).LocalPort
'    MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & Index + 1 & tmpstr & "Connect OK! (" & Winsock1(Index).RemoteHost & ")"
'    lerror List1, MsgStr
    
    '-------below add by Elle -----------------
    If OptTestMode(1).Value = True Then
        CmdSendBeg(Index).Enabled = False
    Else
        CmdSendBeg(Index).Enabled = True
    End If

    '-------upper add by Elle------------------
    
    '    CmdSendBeg(Index).Enabled = True       '-------comma by Elle
    
    sck = Winsock1(Index).SocketHandle
    socket(Index) = sck
    optval = -1
    '    ret = setsockopt(socket(Index), SOL_SOCKET, SO_KEEPALIVE, optval, 2)
    
    'Timer2.Enabled = False
    
End Sub

Private Sub Winsock1_ConnectionRequest(Index As Integer, ByVal requestID As Long)
    MsgBox Index & "  DAP Connection Request"

    If Winsock1(Index).State <> sckClosed Then Winsock1(Index).Close
    '接受具有 requestID 參數的
    '連線。
    Winsock1(Index).Accept requestID
    
    iRx(Index) = 0    '------add by Elle
    iTx(Index) = 0    '------add by Elle
    iLoss(Index) = 0  '------add by Elle
End Sub

Function CheckRcvData(Index As Integer, DataStr As String) As Boolean
    Dim idx As Integer, ret As Integer
    
    'Debug.Print DataStr
    CheckRcvData = False

    '--- Check Total Length ------
    If Len(DataStr) <> TxtSendDataLen(Index) Then Exit Function    'Receive Fail
    
    '--- Check Packet Head -------
    idx = InStr(DataStr, CODE_PKET_HEAD)

    If idx <= 0 Then Exit Function       'Format Error
        
    '--- Check Packket Data Content ----
    If Mid(DataStr, LEN_PKET_HEAD + 1) <> TxtSendData(Index) Then Exit Function    'Data Error
    
    '--- Data Format Exact -------
    CheckRcvData = True
    
End Function

Private Sub Winsock1_DataArrival(Index As Integer, ByVal bytesTotal As Long)
    Dim tmpstr            As String, op As String, DataStr As String, HeadStr As String
    Dim ret               As Long, lens As Integer, idx As Integer, i As Long
    Dim flag              As Boolean
    Dim OldData           As String, GoodStr As String, AccCmd As String
    Dim DapData()         As Byte, tran_id As Integer
    Dim MsgStr            As String
    Dim tmpNo             As Long
    Static GetHeadFlag(31) As Boolean, Pket_No(31) As Long
    Dim pkno As Long
        
    Const POS_TRAN_ID = 4           'tran_id
    Const POS_CMD_ACCCMD = 9        'Acc_Cmd:Sub-Sub-Cmd
    Const POS_CMD_GOOD = 10         '"G" data position
        
    On Error GoTo ERRCMD
        
    flag = False
        
    ReDim DapData(bytesTotal)
        
    If OptTestMode(0).Value = True Then         'LoopBack Test
        idx = Index
    Else
        idx = Index      '----------orginal-> idx=0 change by Elle

    End If

    Winsock1(Index).GetData DapData, vbByte
    lens = bytesTotal
        
    DataStr = Bin2Str(DapData, 0, lens)
       
    '----------below add by Elle-------------------
    '       If lens > Val(TxtSendDataLentoall.Text) Then
    '       Debug.Print "Stop"
    '       End If
    '----------upper add by Elle-------------------
        
    '-------------------------------------------------------------------------------------------------
    #If 1 Then
        RcvDataBuf(idx) = RcvDataBuf(idx) & DataStr
DATA_NEXT:

        If Len(RcvDataBuf(idx)) < TxtSendDataLen(idx) Then Exit Sub     'Have Head, Data Pket Not Rcv Finish
                    
        ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data

        If ret <> 1 Then                 'no head, ignore the data
            If ret = 0 Then                 'no head, ignore the data
                OldData = RcvDataBuf(idx)
                RcvDataBuf(idx) = ""
            Else
                OldData = Left(RcvDataBuf(idx), ret - 1)
                RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)     'Save Old Data
            End If
            
DATA_ERR:
            MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & idx + 1 & "    Data Error: Garbage Data=" & OldData & ", Old PketNo=" & Hex(TxtRcvPket(idx))
            lerror List1, MsgStr

            Exit Sub

        End If

        #If 0 Then
            tmpNo = AscW(Mid(RcvDataBuf(idx), 5, 1))                        'New PketNo Low
            tmpNo = AscW(Mid(RcvDataBuf(idx), 4, 1)) + tmpNo * &H100        'New PketNo High
            'Pket_No(idx) = tmpNo
        #Else
            tmpNo = CLng("&H" + Mid(RcvDataBuf(idx), 4, 4)) 'update 2004/08/12, seq no. is a hex string
        #End If

        ret = TxtSendDataLen(idx)
        OldData = Left(RcvDataBuf(idx), ret)
        '        Debug.Print "OldData= " & OldData    '----------add by Elle
        RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret + 1)
        
        '--- Check Data Format ------
        flag = CheckRcvData(idx, OldData)

        If flag = True Then             'Format Exact
            TxtRcvPket(idx) = tmpNo
            TxtCntRcv(idx).Text = TxtCntRcv(idx).Text + Len(OldData)
        Else
            GoTo DATA_ERR
        End If
        
        '-------------------------------------------------------------------------------------------------
    #Else

        If GetHeadFlag(idx) = True Then       'Already Got Head, Receive data
            RcvDataBuf(idx) = RcvDataBuf(idx) & DataStr
            ret = InStr(4, RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data

            '--- Head in Data --------
            If ret > 0 Then
                If Len(RcvDataBuf(idx)) < ret + LEN_PKET_HEAD Then Exit Sub      'Have Head, Data Pket Not Rcv Finish
                    
                OldData = Left(RcvDataBuf(idx), ret - 1)       'Get Old Data
                'tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 4, 1))      'New PketNo Low
                'tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 3, 1)) + Pket_No(idx) * &H100   'New PketNo High
                'tmpNo = Pket_No(idx)
                RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)

                '--- Check Old Data Recv Finish --------------
                If Len(OldData) >= TxtSendDataLen(idx) Then     'Receive Finish
                    ret = InStr(OldData, CODE_PKET_HEAD)        'Check Have Head in Data

                    '--- Check Need Don't Care Xon/off -----
                    If ChkXOnOff.Value = 1 Then             'Don't Care Xon/off
                        HeadStr = Mid(OldData, ret, LEN_PKET_HEAD)    'Get Heade String
                        OldData = Replace(OldData, Chr(&H11), "", LEN_PKET_HEAD + 1)  'Discard Head
                        OldData = HeadStr & Replace(OldData, Chr(&H13), "")         '&H11/&H13:Xon/Xoff
                    End If
                    
                    ret = InStr(OldData, CODE_PKET_HEAD)        'Check Have Head in Data
                    tmpNo = AscW(Mid(OldData, ret + 4, 1))      'New PketNo High
                    tmpNo = AscW(Mid(OldData, ret + 3, 1)) + tmpNo * &H100   'New PketNo Low
                    '--- Check Data Format ----------
                    flag = CheckRcvData(idx, OldData)

                    If flag = True Then             'Format Exact
                        TxtRcvPket(idx) = tmpNo
                        TxtCntRcv(idx) = TxtCntRcv(idx) + Len(OldData)
                    Else
                        GoTo DATA_ERR
                    End If

                Else                                            'Not Finish, Data Error
                
                    'RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)     'Get New Data
DATA_ERR:
                    MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & idx + 1 & "    Data Error: Old PketNo=" & (tmpNo) & ", OldData=" & OldData & ", New PketNo=" & (Pket_No(idx)) & ", NewData=" & RcvDataBuf(idx)
                    lerror List1, MsgStr
                    
                    Exit Sub

                End If

            Else                'Head not in Data

                If Len(RcvDataBuf(idx)) >= TxtSendDataLen(idx) Then 'Receive Finish
                    '--- Check Data Format ----------
                    ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data
                    tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 4, 1))      'New PketNo Low
                    tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 3, 1)) + tmpNo * &H100 'New PketNo High
                    'Pket_No(idx) = tmpNo
                    OldData = Left(RcvDataBuf(idx), TxtSendDataLen(idx))
                    RcvDataBuf(idx) = Mid(RcvDataBuf(idx), TxtSendDataLen(idx) + 1)

                    'tmpNo = Pket_No(idx)
                    'Pket_No(idx) = 0
                    '--- Check Need Don't Care Xon/off -----
                    If ChkXOnOff.Value = 1 Then             'Don't Care Xon/off
                        HeadStr = Mid(OldData, 1, LEN_PKET_HEAD)    'Get Heade String
                        OldData = Replace(OldData, Chr(&H11), "", LEN_PKET_HEAD + 1)  'Discard Head
                        OldData = HeadStr & Replace(OldData, Chr(&H13), "")         '&H11/&H13:Xon/Xoff
                    End If

                    flag = CheckRcvData(idx, OldData)

                    If flag = True Then             'Format Exact
                        TxtRcvPket(idx) = tmpNo
                        TxtCntRcv(idx) = TxtCntRcv(idx) + Len(OldData)
                    Else
                        GoTo DATA_ERR
                    End If
                End If
            End If  'Head in Data

        Else                                'Un-got Data Head
            RcvDataBuf(idx) = RcvDataBuf(idx) & DataStr
            ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data

            If ret > 0 Then             'Have Head
                If Len(RcvDataBuf(idx)) < ret + LEN_PKET_HEAD Then Exit Sub      'Have Head, Data Pket Not Rcv Finish
                    
                tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 4, 1))      'New PketNo Low
                tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 3, 1)) + tmpNo * &H100 'New PketNo High
                'Pket_No(idx) = tmpNo
                GetHeadFlag(idx) = True

                If ret > 1 Then                 'Log Error Data
                    OldData = Left(RcvDataBuf(idx), ret - 1)
                    'RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)     'Save Old Data
                    MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & idx + 1 & " Data Error: Garbage Data=" & OldData & ", New PketNo=" & Hex(tmpNo)
                    lerror List1, MsgStr
                End If

                '--- Chcek Have Next Packet ---------
                ret = InStr(4, RcvDataBuf(idx), CODE_PKET_HEAD)

                If ret = 0 Then                 'Only the Packet
                    OldData = RcvDataBuf(idx)

                    '--- Check Need Don't Care Xon/off -----
                    If ChkXOnOff.Value = 1 Then             'Don't Care Xon/off
                        HeadStr = Mid(OldData, 1, LEN_PKET_HEAD)    'Get Heade String
                        OldData = Replace(OldData, Chr(&H11), "", LEN_PKET_HEAD + 1)  'Discard Head
                        OldData = HeadStr & Replace(OldData, Chr(&H13), "")         '&H11/&H13:Xon/Xoff
                    End If

                    If Len(OldData) < TxtSendDataLen(idx) Then Exit Sub    'Receive UnFinish
                    RcvDataBuf(idx) = ""
                    GetHeadFlag(idx) = False
                Else                            'Have Next Packet
                    OldData = Left(RcvDataBuf(idx), ret - 1)
                    RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)

                    '--- Check Need Don't Care Xon/off -----
                    If ChkXOnOff.Value = 1 Then             'Don't Care Xon/off
                        HeadStr = Mid(OldData, 1, LEN_PKET_HEAD)    'Get Heade String
                        OldData = Replace(OldData, Chr(&H11), "", LEN_PKET_HEAD + 1)  'Discard Head
                        OldData = HeadStr & Replace(OldData, Chr(&H13), "")         '&H11/&H13:Xon/Xoff
                    End If

                    ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data
                    
                End If

                '--- Check Data Format ------
                flag = CheckRcvData(idx, OldData)

                If flag = True Then             'Format Exact
                    TxtRcvPket(idx) = tmpNo
                    TxtCntRcv(idx) = TxtCntRcv(idx) + Len(OldData)
                End If
                
            Else
                GoTo DATA_ERR
            End If               'No Head
            
        End If

        '-------------------------------------------------------------------------------------------------
    #End If

    '--- Check Receive Packet No -------
    If flag Then            'Receive Format Exact
        ' Debug.Print "tmpNo=" & tmpNo
        ret = tmpNo - Pket_No(idx)      'New-Old

        If ret > 1 Then        'Packet Loss
            #If 1 Then
                MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & idx + 1 & ",   " + CStr(ret) + " Packet Loss: " & CStr(Pket_No(idx) + 1) & "," & CStr(tmpNo)
                lerror List1, MsgStr
            #Else

                For i = 1 To ret - 1
                    MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & idx + 1 & " Packet Loss: PketNo=" & Pket_No(idx) + i
                    lerror List1, MsgStr
                Next i

            #End If
        ElseIf ret <= 0 Then
            MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & idx + 1 & " Packet Reverse: Old PketNo=" & Pket_No(idx) & ", New PketNo=" & tmpNo
            lerror List1, MsgStr
        End If
            
        Pket_No(idx) = tmpNo

        If RcvMode(idx) = RCV_TIMEOUT Then      'Time Out Mode

            'tmpstr = Bin2Str(DapData, 0, lens)
            'RcvDataBuf(idx) = RcvDataBuf(idx) & tmpstr
            If 1 Then   'Len(RcvDataBuf(idx)) >= TxtSendDataLen(idx) Then   'Receive Finish
                If TmrSend(idx).Enabled = True Then   'On Sending
                    WSendData idx, TxtSendData(idx)
                    'Winsock1(idx).SendData RcvDataBuf(idx)
                    TxtCntSendTal(idx) = TxtCntSendTal(idx) + Len(RcvDataBuf(idx))
                    'RcvDataBuf(idx) = ""
                    '--- Reset Timer Counter ------
                    TmrSend(idx).Enabled = False
                    TmrSend(idx).Enabled = True
                End If
            End If
        End If
    End If
            
    'List1.AddItem "Rcv :" & lens

    TxtCntLoss(idx) = TxtCntSend(idx) - TxtCntRcv(idx)

    '-----------------below add by Elle------------------------
    Receive_data(Index) = OldData
              
    If OptTestMode(1).Value = True Then       '-------for cross test
        If idx Mod 2 <> 0 Then
            
            '            If Len(DataStr) <> Val(TxtSendDataLentoall.Text) Then
            '                Debug.Print " Stop  "
            '            End If
  
            '                Debug.Print "Loop real send data= " & OldData

            Winsock1(idx).SendData OldData
            TxtCntSendTal(idx).Text = Val(TxtCntSendTal(idx).Text) + Len(OldData)
                
            '-------below (elle want to know pkno = FFFF)--------------
            If Mid(OldData, 4, 4) = "FFFF" Then
                FFFF_getpkno = FFFF_getpkno + 1
                Debug.Print "OldData= " & OldData
                Debug.Print Time & "    FFFF--> Count= " & FFFF_getpkno     '---------more than FFFF
                TxtSendPketTal(idx).Text = 65535 * FFFF_getpkno             '-------comma by Elle (bytes limits to 00000~FFFFF )
                    
            Else
                pkno = CLng("&H" & Mid(OldData, 4, 4))       '-------comma by Elle (bytes limits to 00000~FFFF)
                TxtSendPketTal(idx).Text = 65535 * FFFF_getpkno + pkno              '-------comma by Elle (bytes limits to 00000~FFFFF )
            End If

            '-------upper (elle want to know pkno=FFFF)----------------
                
            '                pkno = CLng("&H" & Mid(OldData, 4, 4))       '-------comma by Elle (bytes limits to 00000~FFFF)
            '                TxtSendPketTal(idx).Text = pkno              '-------comma by Elle (bytes limits to 00000~FFFFF )
        End If
    End If

    '------------------upper add by Elle-----------------------
        
    If Len(RcvDataBuf(idx)) <> 0 Then
        GoTo DATA_NEXT
    Else

        '---------below add by Elle------------------
        If OptTestMode(1).Value = True And idx = 1 Or idx = 3 Or idx = 5 Or idx = 7 Or idx = 9 Or idx = 11 Or idx = 13 Or idx = 15 _
        Or idx = 17 Or idx = 19 Or idx = 21 Or idx = 23 Or idx = 25 Or idx = 27 Or idx = 29 Or idx = 31 Then '----select "Cross Test" and COM1/3/5/7
        Else

            If InStr(CmdSendBeg(idx).Caption, "Start") > 0 Then   'Press Stop

                '--- Check Full Data Receive --------
                If flag Then
                    
'                    MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & idx + 1 & " Full Receive:" & " Send=" & TxtCntSendTal(idx) & ", Send OK=" & TxtCntSend(idx) & ", Receive=" & TxtCntRcv(idx) & ", Total Loss=" & TxtCntLoss(idx) & ", SendPket=" & TxtSendPketTal(idx) & ", RcvPket=" & TxtRcvPket(idx)
'                    lerror List1, MsgStr
                    OldLoss(idx) = TxtCntLoss(idx)     '------there is value of Loss
                Else
                    OldLoss(idx) = TxtCntLoss(idx)
                End If
            End If
            
        End If

        '---------upper add by Elle------------------
        
        '---------------------------------below comma by Elle-------------------------------------
        '            If InStr(CmdSendBeg(idx).Caption, "Start") > 0 Then   'Press Stop
        '                '--- Check Full Data Receive --------
        '                If flag Then    'TxtCntLoss(idx) = "0" And OldLoss(idx) <> "0" Then
        '
        '                    MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & idx + 1 & " Full Receive:" & " Send=" & TxtCntSendTal(idx) & ", Send OK=" & _
        '                            TxtCntSend(idx) & ", Receive=" & TxtCntRcv(idx) & ", Total Loss=" & TxtCntLoss(idx) & _
        '                            ", SendPket=" & TxtSendPketTal(idx) & ", RcvPket=" & TxtRcvPket(idx)
        '                    lerror List1, MsgStr
        '                    OldLoss(idx) = TxtCntLoss(idx)     '------there is value of Loss
        '                Else
        '                    OldLoss(idx) = TxtCntLoss(idx)
        '                End If
        '            End If
        '---------------------------------upper comma by Elle---------------------------------------
    End If
                
    Exit Sub
        
    Resume
    
ERRCMD:
    MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & Index + 1 & "    Winsock1.DataArrival Err: " & Err.Number & " " & Error
    Debug.Print "Error= " & Err.Description
    lerror List1, MsgStr

    If chk_stopsend.Value = 1 Then      '---------when the state of com happen "Type mismatch", stop sending
        If InStr(MsgStr, " 13 ") > 0 Then
        
            If OptTestMode(1).Value = True Then
                If Val(Index) Mod 2 = 0 Then    '-------For Cross test (stop two connections)
                    Winsock1(Index).Close
                    Winsock1(Index + 1).Close
                    TmrSend(Index).Enabled = False
                Else
                    Winsock1(Index).Close
                    Winsock1(Index - 1).Close
                    TmrSend(Index - 1).Enabled = False
                End If

            Else                               '--------For LoopBack test (stop one connection)
                Winsock1(Index).Close
                TmrSend(Index).Enabled = False
            End If
        
        End If
    End If

    Exit Sub

End Sub

Private Sub Winsock1_Error(Index As Integer, _
                           ByVal Number As Integer, _
                           Description As String, _
                           ByVal Scode As Long, _
                           ByVal Source As String, _
                           ByVal HelpFile As String, _
                           ByVal HelpContext As Long, _
                           CancelDisplay As Boolean)

    On Error Resume Next

    Dim MsgStr As String
    MsgStr = " " & "IP :" & " " & txtip(Index) & "   COM " & Index + 1 & " Winsock Error: (" & Number & ") " & Description & " Send=" & TxtCntSendTal(Index) & ", Send OK=" & TxtCntSend(Index) & ", Receive=" & TxtCntRcv(Index) & ", Total Loss=" & TxtCntLoss(Index)
    lerror List1, MsgStr
    'Simon added
    MsgBox "IP :" & txtip(Index) & " " & " COM " & Index + 1 & "  " & "can't connect !", vbCritical 'added on 2009/09/21
    '        If Index Mod 2 = 0 Then
    '        CmdSendBeg_Click (Index)
    '        cmdCnect_Click (Index)
    '        cmdCnect_Click (Index)
    '        cmdCnect_Click (Index + 1)
    '        cmdCnect_Click (Index + 1)
    '        CmdSendBeg_Click (Index)
    '        Else
    '        CmdSendBeg_Click (Index - 1)
    '        cmdCnect_Click (Index - 1)
    '        cmdCnect_Click (Index - 1)
    '        cmdCnect_Click (Index)
    '        cmdCnect_Click (Index)
    '        CmdSendBeg_Click (Index - 1)
    '        End If
End Sub

Private Sub Winsock1_SendComplete(Index As Integer)
    '        MsgBox Index & "  DAP SendComplete"

End Sub

Private Sub Winsock1_SendProgress(Index As Integer, _
                                  ByVal bytesSent As Long, _
                                  ByVal bytesRemaining As Long)
    ' List1.AddItem Index & "  DAP SendProgress " & bytesSent & ", " & bytesRemaining
    Dim MsgStr As String
    
    TxtCntSend(Index) = TxtCntSend(Index) + bytesSent     '---------sendbyte
     
    '--- Check Remaind Counter ----
    If bytesRemaining > 0 Then          'Have Remaining
        MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & Index + 1 & " WinsockSend Remaind: Sending=" & bytesSent & ", Remaining=" & bytesRemaining
        lerror List1, MsgStr
        
        MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & Index + 1 & " Send=" & TxtCntSendTal(Index) & ", Send OK=" & TxtCntSend(Index) & ", Receive=" & TxtCntRcv(Index) & ", Total Loss=" & TxtCntLoss(Index)
        lerror List1, MsgStr
    End If
    
End Sub
