object Form7: TForm7
  Left = 0
  Top = 0
  Caption = 'Tools'
  ClientHeight = 378
  ClientWidth = 632
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  FormStyle = fsMDIChild
  OldCreateOrder = False
  Visible = True
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object GroupBox1: TGroupBox
    Left = 0
    Top = 9
    Width = 633
    Height = 361
    Caption = ':: FERRAMENTAS ::'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 0
    object Label1: TLabel
      Left = 139
      Top = 15
      Width = 355
      Height = 16
      Caption = 'CUIDADO! Fa'#231'a bakcup antes de utilizar essas fun'#231#245'es.'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clRed
      Font.Height = -13
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label4: TLabel
      Left = 143
      Top = 29
      Width = 347
      Height = 16
      Caption = '(Essas op'#231#245'es ir'#227'o afetar todos os personagens do servidor)'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -13
      Font.Name = 'Tahoma'
      Font.Style = []
      ParentFont = False
    end
    object Button1: TButton
      Left = 40
      Top = 49
      Width = 169
      Height = 28
      Caption = 'Zerar Resets'
      TabOrder = 0
      OnClick = Button1Click
    end
    object Button2: TButton
      Left = 232
      Top = 49
      Width = 169
      Height = 28
      Caption = 'Zerar Master Resets'
      TabOrder = 1
      OnClick = Button2Click
    end
    object Button3: TButton
      Left = 424
      Top = 49
      Width = 169
      Height = 28
      Caption = 'Resetar Skill/Skill Tree'
      TabOrder = 2
      OnClick = Button3Click
    end
    object Button4: TButton
      Left = 424
      Top = 80
      Width = 169
      Height = 28
      Caption = 'Resetar Classe/Quest'
      TabOrder = 3
      OnClick = Button4Click
    end
    object Button5: TButton
      Left = 232
      Top = 80
      Width = 169
      Height = 28
      Caption = 'Resetar Stats'
      TabOrder = 4
      OnClick = Button5Click
    end
    object Button6: TButton
      Left = 40
      Top = 80
      Width = 169
      Height = 28
      Caption = 'Resetar Level/Exp'
      TabOrder = 5
      OnClick = Button6Click
    end
    object Button7: TButton
      Left = 40
      Top = 111
      Width = 169
      Height = 28
      Caption = 'Resetar Inventorio'
      TabOrder = 6
      OnClick = Button7Click
    end
    object Button8: TButton
      Left = 232
      Top = 111
      Width = 169
      Height = 28
      Caption = 'Resetar Ba'#250
      TabOrder = 7
      OnClick = Button8Click
    end
    object Button9: TButton
      Left = 424
      Top = 111
      Width = 169
      Height = 28
      Caption = 'Resetar EffectList'
      TabOrder = 8
      OnClick = Button9Click
    end
    object Button17: TButton
      Left = 208
      Top = 280
      Width = 217
      Height = 34
      Caption = 'Resetar Tudo (sem excluir)'
      TabOrder = 9
      OnClick = Button17Click
    end
    object Button21: TButton
      Left = 424
      Top = 142
      Width = 169
      Height = 28
      Caption = 'Resetar BC'
      TabOrder = 10
      OnClick = Button21Click
    end
    object Button22: TButton
      Left = 232
      Top = 142
      Width = 169
      Height = 28
      Caption = 'Resetar DS'
      TabOrder = 11
      OnClick = Button22Click
    end
    object Button23: TButton
      Left = 424
      Top = 173
      Width = 169
      Height = 28
      Caption = 'Resetar CC'
      TabOrder = 12
      OnClick = Button23Click
    end
    object Button10: TButton
      Left = 40
      Top = 205
      Width = 169
      Height = 28
      Caption = 'Resetar Cash/Gold'
      TabOrder = 13
      OnClick = Button10Click
    end
    object Button11: TButton
      Left = 232
      Top = 235
      Width = 169
      Height = 28
      Caption = 'Excluir Personagens'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -13
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
      TabOrder = 14
      OnClick = Button11Click
    end
    object Button12: TButton
      Left = 424
      Top = 238
      Width = 169
      Height = 28
      Caption = 'Excluir Tudo (Zerar Banco)'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -12
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
      TabOrder = 15
      OnClick = Button12Click
    end
    object Button13: TButton
      Left = 40
      Top = 235
      Width = 169
      Height = 28
      Caption = 'Excluir Guilds'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clBlack
      Font.Height = -13
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
      TabOrder = 16
      OnClick = Button13Click
    end
    object Button14: TButton
      Left = 40
      Top = 142
      Width = 169
      Height = 28
      Caption = 'Resetar Zen'
      TabOrder = 17
      OnClick = Button14Click
    end
    object Button15: TButton
      Left = 40
      Top = 204
      Width = 169
      Height = 28
      Caption = 'Resetar WC/WP/GP'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -13
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
      TabOrder = 18
      OnClick = Button15Click
    end
    object Button16: TButton
      Left = 40
      Top = 173
      Width = 169
      Height = 28
      Caption = 'Resetar IT'
      TabOrder = 19
      OnClick = Button16Click
    end
    object Button18: TButton
      Left = 232
      Top = 173
      Width = 169
      Height = 28
      Caption = 'Resetar Duel'
      TabOrder = 20
      OnClick = Button18Click
    end
    object Button19: TButton
      Left = 424
      Top = 204
      Width = 169
      Height = 28
      Caption = 'Resetar Inv.MUUN'
      TabOrder = 21
      OnClick = Button19Click
    end
    object Button20: TButton
      Left = 232
      Top = 204
      Width = 169
      Height = 28
      Caption = 'Resetar CashShop Inv.'
      TabOrder = 22
      OnClick = Button20Click
    end
    object Button24: TButton
      Left = 232
      Top = 204
      Width = 169
      Height = 28
      Caption = 'Resetar PcPoints'
      TabOrder = 23
      OnClick = Button24Click
    end
  end
end
