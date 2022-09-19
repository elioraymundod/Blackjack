'En este formulario se desarrolla el juego

Public Class Juego
    'Imagenes
    Dim salir_foc As Image = Global.BlackJack.My.Resources.Resources.salir_foc
    Dim salir_press As Image = Global.BlackJack.My.Resources.Resources.salir_press
    Dim salir_normal As Image = Global.BlackJack.My.Resources.Resources.salir_normal
    Dim seg_normal As Image = Global.BlackJack.My.Resources.Resources.seg_normal
    Dim seg_press As Image = Global.BlackJack.My.Resources.Resources.seg_press
    Dim seg_foc As Image = Global.BlackJack.My.Resources.Resources.seg_foc
    Dim doblarmano_normal As Image = Global.BlackJack.My.Resources.Resources.doblarmano_normal
    Dim doblarmano_press As Image = Global.BlackJack.My.Resources.Resources.doblarmano_press
    Dim doblarmano_foc As Image = Global.BlackJack.My.Resources.Resources.doblarmano_foc
    Dim doblar_normal As Image = Global.BlackJack.My.Resources.Resources.doblar_normal
    Dim doblar_press As Image = Global.BlackJack.My.Resources.Resources.doblar_press
    Dim doblar_foc As Image = Global.BlackJack.My.Resources.Resources.doblar_foc
    Dim pedirc_normal As Image = Global.BlackJack.My.Resources.Resources.pedirc_normal
    Dim pedirc_press As Image = Global.BlackJack.My.Resources.Resources.pedirc_press
    Dim pedirc_foc As Image = Global.BlackJack.My.Resources.Resources.pedirc_foc
    Dim plan_normal As Image = Global.BlackJack.My.Resources.Resources.plan_normal
    Dim plan_press As Image = Global.BlackJack.My.Resources.Resources.plan_press
    Dim plan_foc As Image = Global.BlackJack.My.Resources.Resources.plan_foc
    Dim conf_normal As Image = Global.BlackJack.My.Resources.Resources.conf_normal
    Dim conf_foc As Image = Global.BlackJack.My.Resources.Resources.conf_foc
    Dim conf_press As Image = Global.BlackJack.My.Resources.Resources.conf_press
    Dim siguiente_normal As Image = Global.BlackJack.My.Resources.Resources.siguiente_normal
    Dim siguiente_foc As Image = Global.BlackJack.My.Resources.Resources.siguiente_foc
    Dim siguiente_press As Image = Global.BlackJack.My.Resources.Resources.siguiente_press
    Dim reiniap_normal As Image = Global.BlackJack.My.Resources.Resources.reiniap_normal
    Dim reiniap_press As Image = Global.BlackJack.My.Resources.Resources.reiniap_press
    Dim reiniap_foc As Image = Global.BlackJack.My.Resources.Resources.reiniap_foc
    Dim guardarp_normal As Image = Global.BlackJack.My.Resources.Resources.guardarp_normal
    Dim guardarp_foc As Image = Global.BlackJack.My.Resources.Resources.guardarp_foc
    Dim guardarp_press As Image = Global.BlackJack.My.Resources.Resources.guardarp_press
    Dim apos_normal As Image = Global.BlackJack.My.Resources.Resources.apos_normal
    Dim apos_press As Image = Global.BlackJack.My.Resources.Resources.apos_press
    Dim apos_foc As Image = Global.BlackJack.My.Resources.Resources.apos_foc
    Dim panelloser As Image = Global.BlackJack.My.Resources.Resources.panelloser
    Dim arrow As Image = Global.BlackJack.My.Resources.Resources.arrow
    Dim nuevapartida_foc As Image = Global.BlackJack.My.Resources.Resources.nuevapartida_foc
    Dim nuevapartida_normal As Image = Global.BlackJack.My.Resources.Resources.nuevapartida_normal
    Dim nuevapartida_press As Image = Global.BlackJack.My.Resources.Resources.nuevapartida_press
    Dim si_normal As Image = Global.BlackJack.My.Resources.Resources.si_normal
    Dim si_foc As Image = Global.BlackJack.My.Resources.Resources.si_foc
    Dim si_press As Image = Global.BlackJack.My.Resources.Resources.si_press
    Dim no_foc As Image = Global.BlackJack.My.Resources.Resources.no_foc
    Dim no_normal As Image = Global.BlackJack.My.Resources.Resources.no_normal
    Dim no_press As Image = Global.BlackJack.My.Resources.Resources.no_press
    Dim sonido_hab_normal As Image = Global.BlackJack.My.Resources.Resources.sonido_hab_normal
    Dim sonido_hab_foc As Image = Global.BlackJack.My.Resources.Resources.sonido_hab_foc
    Dim sonido_nohab_normal As Image = Global.BlackJack.My.Resources.Resources.sonido_nohab_normal
    Dim sonido_nohab_foc As Image = Global.BlackJack.My.Resources.Resources.sonido_nohab_foc
    Dim musica_hab_normal As Image = Global.BlackJack.My.Resources.Resources.musica_hab_normal
    Dim musica_hab_foc As Image = Global.BlackJack.My.Resources.Resources.musica_hab_foc
    Dim musica_nohab_normal As Image = Global.BlackJack.My.Resources.Resources.musica_nohab_normal
    Dim musica_nohab_foc As Image = Global.BlackJack.My.Resources.Resources.musica_nohab_foc
    'Controles
    Dim panelConfiguracion = New System.Windows.Forms.Panel()
    Dim panelConfirmacion = New System.Windows.Forms.Panel()
    Dim imagenblackjack As PictureBox = New PictureBox()
    Dim arrow_img As PictureBox = New PictureBox()
    Dim cartaVolteada As PictureBox = New PictureBox()
    Dim cartaVolteada2 As PictureBox = New PictureBox()
    Dim cartasJugadores(5, 5) As PictureBox
    Dim panelinfjugadores(5) As PictureBox
    Dim winlose(5) As PictureBox
    Dim panelpunteojugadores(5) As PictureBox
    Dim punteojugadores(5) As Label
    Dim dinerojugadores(5) As Label
    Dim dineroapostado(5) As Label
    Dim numerojugador(5) As Label
    Dim mensaje As Label = New Label()
    Dim mensaje2 As Label = New Label()
    Dim mensaje3 As Label = New Label()
    Friend WithEvents musica_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents sonido_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents cerrar_button As PictureBox = New PictureBox()
    Friend WithEvents si_button As PictureBox = New PictureBox()
    Friend WithEvents no_button As PictureBox = New PictureBox()
    Friend WithEvents conf_button As PictureBox = New PictureBox()
    Friend WithEvents seguro_button As PictureBox = New PictureBox()
    Friend WithEvents doblarmano_button As PictureBox = New PictureBox()
    Friend WithEvents doblar_button As PictureBox = New PictureBox()
    Friend WithEvents pedircarta_button As PictureBox = New PictureBox()
    Friend WithEvents plantarse_button As PictureBox = New PictureBox()
    Friend WithEvents apos_button As PictureBox = New PictureBox()
    Friend WithEvents reiniap_button As PictureBox = New PictureBox()
    Friend WithEvents siguiente_button As PictureBox = New PictureBox()
    Friend WithEvents ficha5_button As PictureBox = New PictureBox()
    Friend WithEvents ficha10_button As PictureBox = New PictureBox()
    Friend WithEvents ficha50_button As PictureBox = New PictureBox()
    Friend WithEvents ficha100_button As PictureBox = New PictureBox()
    Friend WithEvents ficha500_button As PictureBox = New PictureBox()
    Friend WithEvents ficha1000_button As PictureBox = New PictureBox()
    Friend WithEvents nuevap_button As PictureBox = New PictureBox()
    Friend WithEvents guardarp_button As PictureBox = New PictureBox()
    Friend WithEvents cerrarconf_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents timer0 As Timer = New Timer()
    Friend WithEvents timer1 As Timer = New Timer()
    Friend WithEvents timer2 As Timer = New Timer()
    Friend WithEvents timer3 As Timer = New Timer()
    Friend WithEvents timer4 As Timer = New Timer()
    Friend WithEvents timer5 As Timer = New Timer()
    Friend WithEvents timer6 As Timer = New Timer()
    Friend WithEvents timer7 As Timer = New Timer()
    'Otras Variables
    Dim _guardarcargar As GuardarCargar = New GuardarCargar()
    Dim cartas(5, 14) As Image
    Dim cartaOcultaCrupier As Image
    Dim cartaAScrupier As Boolean
    Dim valorCartaOcultaCrupier As Integer
    Dim valorCartaOcultaSecundario As Integer
    Dim numeroJugadores As Integer
    Dim numeroJugadoresIniciales As Integer
    Dim dineroInicial As Integer
    Dim apuestaMinima As Integer
    Dim jugadores(5) As Jugador
    Dim jugadorActual As Integer = 1
    Dim sepagaSeguro As Boolean = False
    Dim multijugador = False
    Dim meta As Integer
    Dim doblarRegla As Boolean
    Dim musichab As Boolean = True
    Dim sonidohab As Boolean = True
    'Arrastre
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim actdesm As Boolean = True
    Dim pop As IO.Stream = Global.BlackJack.My.Resources.Resources.pop
    Dim play1 As System.Media.SoundPlayer = New Media.SoundPlayer
    Dim ris As IO.Stream = Global.BlackJack.My.Resources.Resources.ris
    Dim play2 As System.Media.SoundPlayer = New Media.SoundPlayer


    Public Sub IniciarComponentes()
        play1.Stream = pop
        play2.Stream = ris
        'panelConfiguracion
        Me.panelConfiguracion.BackColor = System.Drawing.Color.Transparent
        Me.panelConfiguracion.BackgroundImage = Global.BlackJack.My.Resources.Resources.transp
        Me.panelConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelConfiguracion.Name = "panelConfiguracion"
        Me.panelConfiguracion.Location = New System.Drawing.Point(275, 265)
        Me.panelConfiguracion.Size = New System.Drawing.Size(310, 200)
        Me.panelConfiguracion.Visible = False
        Me.Controls.Add(Me.panelConfiguracion)
        Me.panelConfiguracion.BringToFront()
        'panelConfirmacion
        Me.panelConfirmacion.BackColor = System.Drawing.Color.Transparent
        Me.panelConfirmacion.BackgroundImage = Global.BlackJack.My.Resources.Resources.mad
        Me.panelConfirmacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelConfirmacion.Name = "panelConfirmacion"
        Me.panelConfirmacion.Location = New System.Drawing.Point(230, 200)
        Me.panelConfirmacion.Size = New System.Drawing.Size(496, 169)
        Me.panelConfirmacion.Visible = False
        Me.Controls.Add(Me.panelConfirmacion)
        Me.panelConfirmacion.BringToFront()
        'cerrarconf_button
        Me.cerrarconf_button.AccessibleName = "CerrarConfiguracion"
        Me.cerrarconf_button.Location = New System.Drawing.Point(250, 10)
        Me.cerrarconf_button.Name = "cerrarconf_button"
        Me.cerrarconf_button.BackColor = Drawing.Color.Transparent
        Me.cerrarconf_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.cerrarconf_button.Size = New System.Drawing.Size(50, 50)
        Me.cerrarconf_button.BackgroundImage = salir_normal
        Me.cerrarconf_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfiguracion.Controls.Add(Me.cerrarconf_button)
        'guardarp_button
        Me.guardarp_button.AccessibleName = "Guardar Partida"
        Me.guardarp_button.Location = New System.Drawing.Point(20, 130)
        Me.guardarp_button.Name = "guardarp_button"
        Me.guardarp_button.BackColor = Drawing.Color.Transparent
        Me.guardarp_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.guardarp_button.Size = New System.Drawing.Size(202, 43)
        Me.guardarp_button.BackgroundImage = guardarp_normal
        Me.guardarp_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfiguracion.Controls.Add(Me.guardarp_button)
        'si_button
        Me.si_button.AccessibleName = "Si"
        Me.si_button.Location = New System.Drawing.Point(100, 100)
        Me.si_button.Name = "si_button"
        Me.si_button.BackColor = Drawing.Color.Transparent
        Me.si_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.si_button.Size = New System.Drawing.Size(56, 40)
        Me.si_button.BackgroundImage = si_normal
        Me.si_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfirmacion.Controls.Add(Me.si_button)
        'no_button
        Me.no_button.AccessibleName = "No"
        Me.no_button.Location = New System.Drawing.Point(346, 100)
        Me.no_button.Name = "no_button"
        Me.no_button.BackColor = Drawing.Color.Transparent
        Me.no_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.no_button.Size = New System.Drawing.Size(56, 40)
        Me.no_button.BackgroundImage = no_normal
        Me.no_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfirmacion.Controls.Add(Me.no_button)
        'musica_button
        Me.musica_button.AccessibleName = "Musica"
        Me.musica_button.Location = New System.Drawing.Point(20, 30)
        Me.musica_button.Name = "musica_button"
        Me.musica_button.BackColor = Drawing.Color.Transparent
        Me.musica_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.musica_button.Size = New System.Drawing.Size(80, 80)
        If musichab Then
            Me.musica_button.BackgroundImage = musica_hab_normal
        Else
            Me.musica_button.BackgroundImage = musica_nohab_normal
        End If
        Me.musica_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfiguracion.Controls.Add(Me.musica_button)
        'sonido_button
        Me.sonido_button.AccessibleName = "Sonido"
        Me.sonido_button.Location = New System.Drawing.Point(120, 30)
        Me.sonido_button.Name = "sonido_button"
        Me.sonido_button.BackColor = Drawing.Color.Transparent
        Me.sonido_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.sonido_button.Size = New System.Drawing.Size(80, 80)
        If sonidohab Then
            Me.sonido_button.BackgroundImage = sonido_hab_normal
        Else
            Me.sonido_button.BackgroundImage = sonido_nohab_normal
        End If
        Me.sonido_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfiguracion.Controls.Add(Me.sonido_button)
        'nuevap_button
        Me.nuevap_button.AccessibleName = "Nueva Partida"
        Me.nuevap_button.Location = New System.Drawing.Point(333, 300)
        Me.nuevap_button.Name = "nuevap_button"
        Me.nuevap_button.BackColor = Drawing.Color.Transparent
        Me.nuevap_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.nuevap_button.Size = New System.Drawing.Size(222, 40)
        Me.nuevap_button.BackgroundImage = nuevapartida_normal
        Me.nuevap_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.nuevap_button)
        Me.nuevap_button.Visible = False
        'conf_button
        Me.conf_button.AccessibleName = "Configuracion"
        Me.conf_button.Location = New System.Drawing.Point(1238, 608)
        Me.conf_button.Name = "conf_button"
        Me.conf_button.BackColor = Drawing.Color.Transparent
        Me.conf_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.conf_button.Size = New System.Drawing.Size(50, 50)
        Me.conf_button.BackgroundImage = conf_normal
        Me.conf_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.conf_button)
        'cerrar_button
        Me.cerrar_button.AccessibleName = "Salir"
        Me.cerrar_button.Location = New System.Drawing.Point(1245, 5)
        Me.cerrar_button.Name = "cerrar_button"
        Me.cerrar_button.BackColor = Drawing.Color.Transparent
        Me.cerrar_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.cerrar_button.Size = New System.Drawing.Size(40, 40)
        Me.cerrar_button.BackgroundImage = salir_normal
        Me.cerrar_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.cerrar_button)
        'seguro_button
        Me.seguro_button.AccessibleName = "Seguro"
        Me.seguro_button.Location = New System.Drawing.Point(12, 608)
        Me.seguro_button.Name = "seguro_button"
        Me.seguro_button.BackColor = Drawing.Color.Transparent
        Me.seguro_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.seguro_button.Size = New System.Drawing.Size(137, 40)
        Me.seguro_button.BackgroundImage = seg_normal
        Me.seguro_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.seguro_button)
        seguro_button.Visible = False
        'doblarmano_button
        Me.doblarmano_button.AccessibleName = "DoblarMano"
        Me.doblarmano_button.Location = New System.Drawing.Point(161, 608)
        Me.doblarmano_button.Name = "doblarmano_button"
        Me.doblarmano_button.BackColor = Drawing.Color.Transparent
        Me.doblarmano_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.doblarmano_button.Size = New System.Drawing.Size(163, 40)
        Me.doblarmano_button.BackgroundImage = doblarmano_normal
        Me.doblarmano_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.doblarmano_button)
        doblarmano_button.Visible = False
        'doblar_button
        Me.doblar_button.AccessibleName = "Doblar"
        Me.doblar_button.Location = New System.Drawing.Point(336, 608)
        Me.doblar_button.Name = "doblar_button"
        Me.doblar_button.BackColor = Drawing.Color.Transparent
        Me.doblar_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.doblar_button.Size = New System.Drawing.Size(137, 40)
        Me.doblar_button.BackgroundImage = doblar_normal
        Me.doblar_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.doblar_button)
        doblar_button.Visible = False
        'pedircarta_button
        Me.pedircarta_button.AccessibleName = "PedirCarta"
        Me.pedircarta_button.Location = New System.Drawing.Point(700, 608)
        Me.pedircarta_button.Name = "pedircarta_button"
        Me.pedircarta_button.BackColor = Drawing.Color.Transparent
        Me.pedircarta_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.pedircarta_button.Size = New System.Drawing.Size(180, 40)
        Me.pedircarta_button.BackgroundImage = pedirc_normal
        Me.pedircarta_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.pedircarta_button)
        pedircarta_button.Visible = False
        'plantarse_button
        Me.plantarse_button.AccessibleName = "Plantarse"
        Me.plantarse_button.Location = New System.Drawing.Point(743, 556)
        Me.plantarse_button.Name = "plantarse_button"
        Me.plantarse_button.BackColor = Drawing.Color.Transparent
        Me.plantarse_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.plantarse_button.Size = New System.Drawing.Size(137, 40)
        Me.plantarse_button.BackgroundImage = plan_normal
        Me.plantarse_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.plantarse_button)
        plantarse_button.Visible = False
        'apos_button
        Me.apos_button.AccessibleName = "Apostar"
        Me.apos_button.Location = New System.Drawing.Point(375, 300)
        Me.apos_button.Name = "apos_button"
        Me.apos_button.BackColor = Drawing.Color.Transparent
        Me.apos_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.apos_button.Size = New System.Drawing.Size(137, 40)
        Me.apos_button.BackgroundImage = apos_normal
        Me.apos_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.apos_button)
        apos_button.Visible = True
        'reiniap_button
        Me.reiniap_button.AccessibleName = "ReiniciarApuesta"
        Me.reiniap_button.Location = New System.Drawing.Point(342, 350)
        Me.reiniap_button.Name = "reiniap_button"
        Me.reiniap_button.BackColor = Drawing.Color.Transparent
        Me.reiniap_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.reiniap_button.Size = New System.Drawing.Size(203, 40)
        Me.reiniap_button.BackgroundImage = reiniap_normal
        Me.reiniap_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.reiniap_button)
        reiniap_button.Visible = True
        'siguiente_button
        Me.siguiente_button.AccessibleName = "Siguiente"
        Me.siguiente_button.Location = New System.Drawing.Point(354, 300)
        Me.siguiente_button.Name = "siguiente_button"
        Me.siguiente_button.BackColor = Drawing.Color.Transparent
        Me.siguiente_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.siguiente_button.Size = New System.Drawing.Size(180, 40)
        Me.siguiente_button.BackgroundImage = siguiente_normal
        Me.siguiente_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.siguiente_button)
        siguiente_button.Visible = False
        'ficha5_button
        Me.ficha5_button.AccessibleName = "ficha5"
        Me.ficha5_button.Location = New System.Drawing.Point(950, 415)
        Me.ficha5_button.Name = "ficha5_button"
        Me.ficha5_button.BackColor = Drawing.Color.Transparent
        Me.ficha5_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.ficha5_button.Size = New System.Drawing.Size(75, 75)
        Me.ficha5_button.BackgroundImage = Global.BlackJack.My.Resources.Resources.ficha5
        Me.ficha5_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.ficha5_button)
        ficha5_button.Visible = True
        'ficha10_button
        Me.ficha10_button.AccessibleName = "ficha10"
        Me.ficha10_button.Location = New System.Drawing.Point(1050, 415)
        Me.ficha10_button.Name = "ficha10_button"
        Me.ficha10_button.BackColor = Drawing.Color.Transparent
        Me.ficha10_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.ficha10_button.Size = New System.Drawing.Size(75, 75)
        Me.ficha10_button.BackgroundImage = Global.BlackJack.My.Resources.Resources.ficha10
        Me.ficha10_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.ficha10_button)
        'ficha50_button
        Me.ficha50_button.AccessibleName = "ficha50"
        Me.ficha50_button.Location = New System.Drawing.Point(1150, 415)
        Me.ficha50_button.Name = "ficha50_button"
        Me.ficha50_button.BackColor = Drawing.Color.Transparent
        Me.ficha50_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.ficha50_button.Size = New System.Drawing.Size(75, 75)
        Me.ficha50_button.BackgroundImage = Global.BlackJack.My.Resources.Resources.ficha50
        Me.ficha50_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.ficha50_button)
        'ficha100_button
        Me.ficha100_button.AccessibleName = "ficha100"
        Me.ficha100_button.Location = New System.Drawing.Point(950, 500)
        Me.ficha100_button.Name = "ficha100_button"
        Me.ficha100_button.BackColor = Drawing.Color.Transparent
        Me.ficha100_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.ficha100_button.Size = New System.Drawing.Size(75, 75)
        Me.ficha100_button.BackgroundImage = Global.BlackJack.My.Resources.Resources.ficha100
        Me.ficha100_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.ficha100_button)
        'ficha500_button
        Me.ficha500_button.AccessibleName = "ficha500"
        Me.ficha500_button.Location = New System.Drawing.Point(1050, 500)
        Me.ficha500_button.Name = "ficha500_button"
        Me.ficha500_button.BackColor = Drawing.Color.Transparent
        Me.ficha500_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.ficha500_button.Size = New System.Drawing.Size(75, 75)
        Me.ficha500_button.BackgroundImage = Global.BlackJack.My.Resources.Resources.ficha500
        Me.ficha500_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.ficha500_button)
        'ficha1000_button
        Me.ficha1000_button.AccessibleName = "ficha1000"
        Me.ficha1000_button.Location = New System.Drawing.Point(1150, 500)
        Me.ficha1000_button.Name = "ficha1000_button"
        Me.ficha1000_button.BackColor = Drawing.Color.Transparent
        Me.ficha1000_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.ficha1000_button.Size = New System.Drawing.Size(75, 75)
        Me.ficha1000_button.BackgroundImage = Global.BlackJack.My.Resources.Resources.ficha1000
        Me.ficha1000_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.ficha1000_button)
        'cartaVolteada
        Me.cartaVolteada.AccessibleName = "CartaVolteada"
        Me.cartaVolteada.Location = New System.Drawing.Point(764, 25)
        Me.cartaVolteada.Name = "cartaVolteada"
        Me.cartaVolteada.BackColor = Drawing.Color.Transparent
        Me.cartaVolteada.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.cartaVolteada.Size = New System.Drawing.Size(67, 100)
        Me.cartaVolteada.BackgroundImage = Global.BlackJack.My.Resources.Resources.reversoCarta
        Me.Controls.Add(Me.cartaVolteada)
        'cartaVolteada2
        Me.cartaVolteada2.AccessibleName = "CartaVolteada"
        Me.cartaVolteada2.Location = New System.Drawing.Point(764, 25)
        Me.cartaVolteada2.Name = "cartaVolteada"
        Me.cartaVolteada2.BackColor = Drawing.Color.Transparent
        Me.cartaVolteada2.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.cartaVolteada2.Size = New System.Drawing.Size(67, 100)
        Me.cartaVolteada2.BackgroundImage = Global.BlackJack.My.Resources.Resources.reversoCarta
        Me.Controls.Add(Me.cartaVolteada2)
        'mensajes
        mensaje.AutoSize = True
        mensaje.Font = New System.Drawing.Font("Garamond", 20.0!)
        mensaje.ForeColor = System.Drawing.Color.White
        mensaje.BackColor = Drawing.Color.Transparent
        mensaje.Location = New System.Drawing.Point(950, 610)
        mensaje.Name = ("mensaje")
        mensaje.Size = New System.Drawing.Size(40, 45)
        mensaje.Text = "Apuesta JUGADOR 1"
        Controls.Add(mensaje)
        'mensajes
        mensaje2.AutoSize = True
        mensaje2.Font = New System.Drawing.Font("Garamond", 20.0!)
        mensaje2.ForeColor = System.Drawing.Color.White
        mensaje2.BackColor = Drawing.Color.Transparent
        mensaje2.Location = New System.Drawing.Point(10, 620)
        mensaje2.Name = ("mensaje2")
        mensaje2.Size = New System.Drawing.Size(40, 45)
        mensaje2.Text = ""
        Controls.Add(mensaje2)
        'mensajes
        mensaje3.AutoSize = True
        mensaje3.Font = New System.Drawing.Font("Garamond", 20.0!)
        mensaje3.ForeColor = System.Drawing.Color.White
        mensaje3.BackColor = Drawing.Color.Transparent
        mensaje3.Location = New System.Drawing.Point(130, 30)
        mensaje3.Name = ("mensaje3")
        mensaje3.Size = New System.Drawing.Size(40, 45)
        mensaje3.Text = "¿Desea salir del juego?"
        Me.panelConfirmacion.Controls.Add(mensaje3)
        'Otros componentes
        timer0.Interval = 17
        timer1.Interval = 17
        timer2.Interval = 17
        timer3.Interval = 17
        timer4.Interval = 17
        timer5.Interval = 17
        timer6.Interval = 17
        timer7.Interval = 1000
        cargarImagenesCartas()
        'componentesDeJugadores
        IniciarComponentesDeJugadores()
    End Sub

    Public Sub IniciarComponentesDeJugadores()
        For i = numeroJugadores To 1 Step -1
            dinerojugadores(i).AutoSize = True
            dinerojugadores(i).Font = New System.Drawing.Font("Garamond", 30.0!)
            dinerojugadores(i).ForeColor = System.Drawing.Color.White
            dinerojugadores(i).Image = Global.BlackJack.My.Resources.Resources.fondo
            dinerojugadores(i).Location = New System.Drawing.Point(1095, 73 + (65 * (i - 1)))
            dinerojugadores(i).Name = ("dinerojugadores" & i)
            dinerojugadores(i).Size = New System.Drawing.Size(40, 45)
            dinerojugadores(i).Text = dineroInicial
            Controls.Add(dinerojugadores(i))
            dinerojugadores(i).Visible = True
            panelinfjugadores(i).AccessibleName = ("paneljugadores" & i)
            panelinfjugadores(i).Location = New System.Drawing.Point(900, (65 * i))
            panelinfjugadores(i).Name = ("paneljugadores" & i)
            panelinfjugadores(i).BackColor = Drawing.Color.Transparent
            panelinfjugadores(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
            panelinfjugadores(i).Size = New System.Drawing.Size(400, 60)
            Select Case i
                Case 1
                    panelinfjugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.p1
                Case 2
                    panelinfjugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.p2
                Case 3
                    panelinfjugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.p3
                Case 4
                    panelinfjugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.p4
                Case 5
                    panelinfjugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.p5
            End Select
            Controls.Add(Me.panelinfjugadores(i))
            panelinfjugadores(i).Visible = True
            jugadores(i).setDinero(dineroInicial)
            jugadores(i).setApuestaActual(apuestaMinima)
            Select Case i
                Case 1
                    winlose(i).AccessibleName = ("win" & i)
                    winlose(i).Location = New System.Drawing.Point(340, 480)
                    winlose(i).Name = ("win" & i)
                    winlose(i).BackColor = Drawing.Color.Transparent
                    winlose(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    winlose(i).Size = New System.Drawing.Size(50, 28)
                    winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
                    Controls.Add(Me.winlose(i))
                    winlose(i).Visible = False
                    punteojugadores(i).AutoSize = True
                    punteojugadores(i).BackColor = Drawing.Color.Transparent
                    punteojugadores(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    punteojugadores(i).ForeColor = System.Drawing.Color.White
                    punteojugadores(i).Location = New System.Drawing.Point(350 + 50, 380 + 20)
                    punteojugadores(i).Name = ("punteojugadores" & i)
                    punteojugadores(i).Size = New System.Drawing.Size(40, 45)
                    punteojugadores(i).Text = ""
                    Controls.Add(punteojugadores(i))
                    punteojugadores(i).Visible = True
                    numerojugador(i).AutoSize = True
                    numerojugador(i).BackColor = Drawing.Color.Transparent
                    numerojugador(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    numerojugador(i).ForeColor = System.Drawing.Color.White
                    numerojugador(i).Location = New System.Drawing.Point(350, 555 + 20)
                    numerojugador(i).Name = ("numerojugador" & i)
                    numerojugador(i).Size = New System.Drawing.Size(40, 45)
                    numerojugador(i).Text = "JUGADOR 1"
                    Controls.Add(numerojugador(i))
                    numerojugador(i).Visible = True
                    dineroapostado(i).AutoSize = True
                    dineroapostado(i).Font = New System.Drawing.Font("Garamond", 16.0!)
                    dineroapostado(i).ForeColor = System.Drawing.Color.White
                    dineroapostado(i).Image = Global.BlackJack.My.Resources.Resources.fondo
                    dineroapostado(i).Location = New System.Drawing.Point(410, 523 + 20)
                    dineroapostado(i).Name = ("dineroapostado" & i)
                    dineroapostado(i).Size = New System.Drawing.Size(40, 45)
                    dineroapostado(i).Text = apuestaMinima
                    Controls.Add(dineroapostado(i))
                    dineroapostado(i).Visible = True
                    panelpunteojugadores(i).AccessibleName = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).Location = New System.Drawing.Point(350, 515 + 20)
                    panelpunteojugadores(i).Name = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).BackColor = Drawing.Color.Transparent
                    panelpunteojugadores(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    panelpunteojugadores(i).Size = New System.Drawing.Size(182, 40)
                    panelpunteojugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.pdin
                    Controls.Add(Me.panelpunteojugadores(i))
                    panelpunteojugadores(i).Visible = True
                    For j = 1 To 5
                        cartasJugadores(i, j).AccessibleName = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).Location = New System.Drawing.Point(350 + ((j - 1) * 20), 410 + 20)
                        cartasJugadores(i, j).Name = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).BackColor = Drawing.Color.Transparent
                        cartasJugadores(i, j).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                        cartasJugadores(i, j).Size = New System.Drawing.Size(67, 100)
                        cartasJugadores(i, j).BackgroundImage = Nothing
                        Controls.Add(Me.cartasJugadores(i, j))
                        cartasJugadores(i, j).Visible = False
                    Next
                Case 2
                    winlose(i).AccessibleName = ("win" & i)
                    winlose(i).Location = New System.Drawing.Point(540, 430)
                    winlose(i).Name = ("win" & i)
                    winlose(i).BackColor = Drawing.Color.Transparent
                    winlose(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    winlose(i).Size = New System.Drawing.Size(50, 28)
                    winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
                    Controls.Add(Me.winlose(i))
                    winlose(i).Visible = False
                    punteojugadores(i).AutoSize = True
                    punteojugadores(i).BackColor = Drawing.Color.Transparent
                    punteojugadores(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    punteojugadores(i).ForeColor = System.Drawing.Color.White
                    punteojugadores(i).Location = New System.Drawing.Point(550 + 50, 330 + 20)
                    punteojugadores(i).Name = ("punteojugadores" & i)
                    punteojugadores(i).Size = New System.Drawing.Size(40, 45)
                    punteojugadores(i).Text = ""
                    Controls.Add(punteojugadores(i))
                    punteojugadores(i).Visible = True
                    numerojugador(i).AutoSize = True
                    numerojugador(i).BackColor = Drawing.Color.Transparent
                    numerojugador(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    numerojugador(i).ForeColor = System.Drawing.Color.White
                    numerojugador(i).Location = New System.Drawing.Point(550, 505 + 20)
                    numerojugador(i).Name = ("numerojugador" & i)
                    numerojugador(i).Size = New System.Drawing.Size(40, 45)
                    numerojugador(i).Text = "JUGADOR 2"
                    Controls.Add(numerojugador(i))
                    numerojugador(i).Visible = True
                    dineroapostado(i).AutoSize = True
                    dineroapostado(i).Font = New System.Drawing.Font("Garamond", 16.0!)
                    dineroapostado(i).ForeColor = System.Drawing.Color.White
                    dineroapostado(i).Image = Global.BlackJack.My.Resources.Resources.fondo
                    dineroapostado(i).Location = New System.Drawing.Point(610, 473 + 20)
                    dineroapostado(i).Name = ("dineroapostado" & i)
                    dineroapostado(i).Size = New System.Drawing.Size(40, 45)
                    dineroapostado(i).Text = apuestaMinima
                    Controls.Add(dineroapostado(i))
                    dineroapostado(i).Visible = True
                    panelpunteojugadores(i).AccessibleName = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).Location = New System.Drawing.Point(550, 465 + 20)
                    panelpunteojugadores(i).Name = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).BackColor = Drawing.Color.Transparent
                    panelpunteojugadores(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    panelpunteojugadores(i).Size = New System.Drawing.Size(182, 40)
                    panelpunteojugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.pdin
                    Controls.Add(Me.panelpunteojugadores(i))
                    panelpunteojugadores(i).Visible = True
                    For j = 1 To 5
                        cartasJugadores(i, j).AccessibleName = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).Location = New System.Drawing.Point(550 + ((j - 1) * 20), 360 + 20)
                        cartasJugadores(i, j).Name = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).BackColor = Drawing.Color.Transparent
                        cartasJugadores(i, j).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                        cartasJugadores(i, j).Size = New System.Drawing.Size(67, 100)
                        cartasJugadores(i, j).BackgroundImage = Nothing
                        Controls.Add(Me.cartasJugadores(i, j))
                        cartasJugadores(i, j).Visible = False
                    Next
                Case 3
                    winlose(i).AccessibleName = ("win" & i)
                    winlose(i).Location = New System.Drawing.Point(140, 430)
                    winlose(i).Name = ("win" & i)
                    winlose(i).BackColor = Drawing.Color.Transparent
                    winlose(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    winlose(i).Size = New System.Drawing.Size(50, 28)
                    winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
                    Controls.Add(Me.winlose(i))
                    winlose(i).Visible = False
                    punteojugadores(i).AutoSize = True
                    punteojugadores(i).BackColor = Drawing.Color.Transparent
                    punteojugadores(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    punteojugadores(i).ForeColor = System.Drawing.Color.White
                    punteojugadores(i).Location = New System.Drawing.Point(150 + 50, 330 + 20)
                    punteojugadores(i).Name = ("punteojugadores" & i)
                    punteojugadores(i).Size = New System.Drawing.Size(40, 45)
                    punteojugadores(i).Text = ""
                    Controls.Add(punteojugadores(i))
                    punteojugadores(i).Visible = True
                    numerojugador(i).AutoSize = True
                    numerojugador(i).BackColor = Drawing.Color.Transparent
                    numerojugador(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    numerojugador(i).ForeColor = System.Drawing.Color.White
                    numerojugador(i).Location = New System.Drawing.Point(150, 505 + 20)
                    numerojugador(i).Name = ("numerojugador" & i)
                    numerojugador(i).Size = New System.Drawing.Size(40, 45)
                    numerojugador(i).Text = "JUGADOR 3"
                    Controls.Add(numerojugador(i))
                    numerojugador(i).Visible = True
                    dineroapostado(i).AutoSize = True
                    dineroapostado(i).Font = New System.Drawing.Font("Garamond", 16.0!)
                    dineroapostado(i).ForeColor = System.Drawing.Color.White
                    dineroapostado(i).Image = Global.BlackJack.My.Resources.Resources.fondo
                    dineroapostado(i).Location = New System.Drawing.Point(210, 473 + 20)
                    dineroapostado(i).Name = ("dineroapostado" & i)
                    dineroapostado(i).Size = New System.Drawing.Size(40, 45)
                    dineroapostado(i).Text = apuestaMinima
                    Controls.Add(dineroapostado(i))
                    dineroapostado(i).Visible = True
                    panelpunteojugadores(i).AccessibleName = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).Location = New System.Drawing.Point(150, 465 + 20)
                    panelpunteojugadores(i).Name = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).BackColor = Drawing.Color.Transparent
                    panelpunteojugadores(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    panelpunteojugadores(i).Size = New System.Drawing.Size(182, 40)
                    panelpunteojugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.pdin
                    Controls.Add(Me.panelpunteojugadores(i))
                    panelpunteojugadores(i).Visible = True
                    For j = 1 To 5
                        cartasJugadores(i, j).AccessibleName = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).Location = New System.Drawing.Point(150 + ((j - 1) * 20), 360 + 20)
                        cartasJugadores(i, j).Name = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).BackColor = Drawing.Color.Transparent
                        cartasJugadores(i, j).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                        cartasJugadores(i, j).Size = New System.Drawing.Size(67, 100)
                        cartasJugadores(i, j).BackgroundImage = Nothing
                        Controls.Add(Me.cartasJugadores(i, j))
                        cartasJugadores(i, j).Visible = False
                    Next
                Case 4
                    winlose(i).AccessibleName = ("win" & i)
                    winlose(i).Location = New System.Drawing.Point(690, 280)
                    winlose(i).Name = ("win" & i)
                    winlose(i).BackColor = Drawing.Color.Transparent
                    winlose(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    winlose(i).Size = New System.Drawing.Size(50, 28)
                    winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
                    Controls.Add(Me.winlose(i))
                    winlose(i).Visible = False
                    punteojugadores(i).AutoSize = True
                    punteojugadores(i).BackColor = Drawing.Color.Transparent
                    punteojugadores(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    punteojugadores(i).ForeColor = System.Drawing.Color.White
                    punteojugadores(i).Location = New System.Drawing.Point(700 + 50, 220 - 20)
                    punteojugadores(i).Name = ("punteojugadores" & i)
                    punteojugadores(i).Size = New System.Drawing.Size(40, 45)
                    punteojugadores(i).Text = ""
                    Controls.Add(punteojugadores(i))
                    punteojugadores(i).Visible = True
                    numerojugador(i).AutoSize = True
                    numerojugador(i).BackColor = Drawing.Color.Transparent
                    numerojugador(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    numerojugador(i).ForeColor = System.Drawing.Color.White
                    numerojugador(i).Location = New System.Drawing.Point(700, 395 - 20)
                    numerojugador(i).Name = ("numerojugador" & i)
                    numerojugador(i).Size = New System.Drawing.Size(40, 45)
                    numerojugador(i).Text = "JUGADOR 4"
                    Controls.Add(numerojugador(i))
                    numerojugador(i).Visible = True
                    dineroapostado(i).AutoSize = True
                    dineroapostado(i).Font = New System.Drawing.Font("Garamond", 16.0!)
                    dineroapostado(i).ForeColor = System.Drawing.Color.White
                    dineroapostado(i).Image = Global.BlackJack.My.Resources.Resources.fondo
                    dineroapostado(i).Location = New System.Drawing.Point(760, 363 - 20)
                    dineroapostado(i).Name = ("dineroapostado" & i)
                    dineroapostado(i).Size = New System.Drawing.Size(40, 45)
                    dineroapostado(i).Text = apuestaMinima
                    dineroapostado(i).Visible = True
                    Controls.Add(dineroapostado(i))
                    panelpunteojugadores(i).AccessibleName = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).Location = New System.Drawing.Point(700, 355 - 20)
                    panelpunteojugadores(i).Name = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).BackColor = Drawing.Color.Transparent
                    panelpunteojugadores(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    panelpunteojugadores(i).Size = New System.Drawing.Size(182, 40)
                    panelpunteojugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.pdin
                    Controls.Add(Me.panelpunteojugadores(i))
                    panelpunteojugadores(i).Visible = True
                    For j = 1 To 5
                        cartasJugadores(i, j).AccessibleName = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).Location = New System.Drawing.Point(700 + ((j - 1) * 20), 250 - 20)
                        cartasJugadores(i, j).Name = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).BackColor = Drawing.Color.Transparent
                        cartasJugadores(i, j).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                        cartasJugadores(i, j).Size = New System.Drawing.Size(67, 100)
                        cartasJugadores(i, j).BackgroundImage = Nothing
                        Controls.Add(Me.cartasJugadores(i, j))
                        cartasJugadores(i, j).Visible = False
                    Next
                Case 5
                    winlose(i).AccessibleName = ("win" & i)
                    winlose(i).Location = New System.Drawing.Point(0, 280)
                    winlose(i).Name = ("win" & i)
                    winlose(i).BackColor = Drawing.Color.Transparent
                    winlose(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    winlose(i).Size = New System.Drawing.Size(50, 28)
                    winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
                    Controls.Add(Me.winlose(i))
                    winlose(i).Visible = False
                    punteojugadores(i).AutoSize = True
                    punteojugadores(i).BackColor = Drawing.Color.Transparent
                    punteojugadores(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    punteojugadores(i).ForeColor = System.Drawing.Color.White
                    punteojugadores(i).Location = New System.Drawing.Point(10 + 50, 220 - 20)
                    punteojugadores(i).Name = ("punteojugadores" & i)
                    punteojugadores(i).Size = New System.Drawing.Size(40, 45)
                    punteojugadores(i).Text = ""
                    Controls.Add(punteojugadores(i))
                    punteojugadores(i).Visible = True
                    numerojugador(i).AutoSize = True
                    numerojugador(i).BackColor = Drawing.Color.Transparent
                    numerojugador(i).Font = New System.Drawing.Font("Garamond", 13.0!)
                    numerojugador(i).ForeColor = System.Drawing.Color.White
                    numerojugador(i).Location = New System.Drawing.Point(10, 395 - 20)
                    numerojugador(i).Name = ("numerojugador" & i)
                    numerojugador(i).Size = New System.Drawing.Size(40, 45)
                    numerojugador(i).Text = "JUGADOR 5"
                    Controls.Add(numerojugador(i))
                    numerojugador(i).Visible = True
                    dineroapostado(i).AutoSize = True
                    dineroapostado(i).Font = New System.Drawing.Font("Garamond", 16.0!)
                    dineroapostado(i).ForeColor = System.Drawing.Color.White
                    dineroapostado(i).Image = Global.BlackJack.My.Resources.Resources.fondo
                    dineroapostado(i).Location = New System.Drawing.Point(70, 363 - 20)
                    dineroapostado(i).Name = ("dineroapostado" & i)
                    dineroapostado(i).Size = New System.Drawing.Size(40, 45)
                    dineroapostado(i).Text = apuestaMinima
                    Controls.Add(dineroapostado(i))
                    dineroapostado(i).Visible = True
                    panelpunteojugadores(i).AccessibleName = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).Location = New System.Drawing.Point(10, 355 - 20)
                    panelpunteojugadores(i).Name = ("panelpunteojugadores" & i)
                    panelpunteojugadores(i).BackColor = Drawing.Color.Transparent
                    panelpunteojugadores(i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                    panelpunteojugadores(i).Size = New System.Drawing.Size(182, 40)
                    panelpunteojugadores(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.pdin
                    Controls.Add(Me.panelpunteojugadores(i))
                    panelpunteojugadores(i).Visible = True
                    For j = 1 To 5
                        cartasJugadores(i, j).AccessibleName = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).Location = New System.Drawing.Point(10 + ((j - 1) * 20), 250 - 20)
                        cartasJugadores(i, j).Name = ("cartasJugadores" & i & "-" & j)
                        cartasJugadores(i, j).BackColor = Drawing.Color.Transparent
                        cartasJugadores(i, j).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
                        cartasJugadores(i, j).Size = New System.Drawing.Size(67, 100)
                        cartasJugadores(i, j).BackgroundImage = Nothing
                        Controls.Add(Me.cartasJugadores(i, j))
                        cartasJugadores(i, j).Visible = False
                    Next
            End Select
        Next
        For i = 1 To 5
            cartasJugadores(0, i).AccessibleName = ("cartasJugadores0-" & i)
            cartasJugadores(0, i).Location = New System.Drawing.Point(360 + ((i - 1) * 20), 40)
            cartasJugadores(0, i).Name = ("cartasJugadores0-" & i)
            cartasJugadores(0, i).BackColor = Drawing.Color.Transparent
            cartasJugadores(0, i).BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
            cartasJugadores(0, i).Size = New System.Drawing.Size(67, 100)
            cartasJugadores(0, i).BackgroundImage = Nothing
            Controls.Add(Me.cartasJugadores(0, i))
            cartasJugadores(0, i).Visible = False
        Next
        punteojugadores(0).AutoSize = True
        punteojugadores(0).BackColor = Drawing.Color.Transparent
        punteojugadores(0).Font = New System.Drawing.Font("Garamond", 13.0!)
        punteojugadores(0).ForeColor = System.Drawing.Color.White
        punteojugadores(0).Location = New System.Drawing.Point(360, 10)
        punteojugadores(0).Name = ("punteojugadores" & 0)
        punteojugadores(0).Size = New System.Drawing.Size(40, 45)
        punteojugadores(0).Text = ""
        Controls.Add(punteojugadores(0))
        'Arrow
        arrow_img.AccessibleName = ("flecha")
        arrow_img.Location = New System.Drawing.Point(900, 75)
        arrow_img.Name = ("arrow_img")
        arrow_img.BackColor = Drawing.Color.Transparent
        arrow_img.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        arrow_img.Size = New System.Drawing.Size(20, 30)
        arrow_img.BackgroundImage = arrow
        Controls.Add(arrow_img)
        arrow_img.BringToFront()
    End Sub

    Public Sub cargarImagenesCartas()
        cartas(1, 1) = Global.BlackJack.My.Resources.Resources.ac
        cartas(1, 2) = Global.BlackJack.My.Resources.Resources._2c
        cartas(1, 3) = Global.BlackJack.My.Resources.Resources._3c
        cartas(1, 4) = Global.BlackJack.My.Resources.Resources._4c
        cartas(1, 5) = Global.BlackJack.My.Resources.Resources._5c
        cartas(1, 6) = Global.BlackJack.My.Resources.Resources._6c
        cartas(1, 7) = Global.BlackJack.My.Resources.Resources._7c
        cartas(1, 8) = Global.BlackJack.My.Resources.Resources._8c
        cartas(1, 9) = Global.BlackJack.My.Resources.Resources._9c
        cartas(1, 10) = Global.BlackJack.My.Resources.Resources._10c
        cartas(1, 11) = Global.BlackJack.My.Resources.Resources.jc
        cartas(1, 12) = Global.BlackJack.My.Resources.Resources.qc
        cartas(1, 13) = Global.BlackJack.My.Resources.Resources.kc
        cartas(2, 1) = Global.BlackJack.My.Resources.Resources.ad
        cartas(2, 2) = Global.BlackJack.My.Resources.Resources._2d
        cartas(2, 3) = Global.BlackJack.My.Resources.Resources._3d
        cartas(2, 4) = Global.BlackJack.My.Resources.Resources._4d
        cartas(2, 5) = Global.BlackJack.My.Resources.Resources._5d
        cartas(2, 6) = Global.BlackJack.My.Resources.Resources._6d
        cartas(2, 7) = Global.BlackJack.My.Resources.Resources._7d
        cartas(2, 8) = Global.BlackJack.My.Resources.Resources._8d
        cartas(2, 9) = Global.BlackJack.My.Resources.Resources._9d
        cartas(2, 10) = Global.BlackJack.My.Resources.Resources._10d
        cartas(2, 11) = Global.BlackJack.My.Resources.Resources.jd
        cartas(2, 12) = Global.BlackJack.My.Resources.Resources.qd
        cartas(2, 13) = Global.BlackJack.My.Resources.Resources.kd
        cartas(3, 1) = Global.BlackJack.My.Resources.Resources.at
        cartas(3, 2) = Global.BlackJack.My.Resources.Resources._2t
        cartas(3, 3) = Global.BlackJack.My.Resources.Resources._3t
        cartas(3, 4) = Global.BlackJack.My.Resources.Resources._4t
        cartas(3, 5) = Global.BlackJack.My.Resources.Resources._5t
        cartas(3, 6) = Global.BlackJack.My.Resources.Resources._6t
        cartas(3, 7) = Global.BlackJack.My.Resources.Resources._7t
        cartas(3, 8) = Global.BlackJack.My.Resources.Resources._8t
        cartas(3, 9) = Global.BlackJack.My.Resources.Resources._9t
        cartas(3, 10) = Global.BlackJack.My.Resources.Resources._10t
        cartas(3, 11) = Global.BlackJack.My.Resources.Resources.jt
        cartas(3, 12) = Global.BlackJack.My.Resources.Resources.qt
        cartas(3, 13) = Global.BlackJack.My.Resources.Resources.kt
        cartas(4, 1) = Global.BlackJack.My.Resources.Resources.ap
        cartas(4, 2) = Global.BlackJack.My.Resources.Resources._2p
        cartas(4, 3) = Global.BlackJack.My.Resources.Resources._3p
        cartas(4, 4) = Global.BlackJack.My.Resources.Resources._4p
        cartas(4, 5) = Global.BlackJack.My.Resources.Resources._5p
        cartas(4, 6) = Global.BlackJack.My.Resources.Resources._6p
        cartas(4, 7) = Global.BlackJack.My.Resources.Resources._7p
        cartas(4, 8) = Global.BlackJack.My.Resources.Resources._8p
        cartas(4, 9) = Global.BlackJack.My.Resources.Resources._9p
        cartas(4, 10) = Global.BlackJack.My.Resources.Resources._10p
        cartas(4, 11) = Global.BlackJack.My.Resources.Resources.jp
        cartas(4, 12) = Global.BlackJack.My.Resources.Resources.qp
        cartas(4, 13) = Global.BlackJack.My.Resources.Resources.kp
    End Sub

    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 5
            jugadores(i) = New Jugador()
            panelinfjugadores(i) = New PictureBox()
            winlose(i) = New PictureBox()
            panelpunteojugadores(i) = New PictureBox()
            punteojugadores(i) = New Label()
            dinerojugadores(i) = New Label()
            dineroapostado(i) = New Label()
            numerojugador(i) = New Label()
            For j = 0 To 5
                cartasJugadores(i, j) = New PictureBox()
            Next
        Next
        IniciarComponentes()
    End Sub

    Private Sub Juego_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        End
    End Sub

    'Acciones de los botones
    ''conf_button
    Private Sub conf_button_Click(sender As Object, e As EventArgs) Handles conf_button.Click
        panelConfiguracion.Visible = True
        panelConfiguracion.bringToFront()
        If sonidohab Then
            play1.Play()
        End If
    End Sub
    Private Sub conf_button_MouseDown(sender As Object, e As EventArgs) Handles conf_button.MouseDown
        conf_button.BackgroundImage = conf_press
    End Sub
    Private Sub conf_button_MouseLeave(sender As Object, e As EventArgs) Handles conf_button.MouseLeave
        conf_button.BackgroundImage = conf_normal
    End Sub
    Private Sub conf_button_MouseMove(sender As Object, e As EventArgs) Handles conf_button.MouseMove
        conf_button.BackgroundImage = conf_foc
    End Sub
    ''cerrar_button
    Private Sub cerrar_button_Click(sender As Object, e As EventArgs) Handles cerrar_button.Click
        Panel1.BringToFront()
        panelConfirmacion.Visible = True
        Panel1.Visible = True
        panelConfirmacion.bringToFront()
        If sonidohab Then
            play1.Play()
        End If
    End Sub
    Private Sub cerrar_button_MouseDown(sender As Object, e As EventArgs) Handles cerrar_button.MouseDown
        cerrar_button.BackgroundImage = salir_press
    End Sub
    Private Sub cerrar_button_MouseLeave(sender As Object, e As EventArgs) Handles cerrar_button.MouseLeave
        cerrar_button.BackgroundImage = salir_normal
    End Sub
    Private Sub cerrar_button_MouseMove(sender As Object, e As EventArgs) Handles cerrar_button.MouseMove
        cerrar_button.BackgroundImage = salir_foc
    End Sub
    ''cerrarconf_button
    Private Sub cerrarconf_button_Click(sender As Object, e As EventArgs) Handles cerrarconf_button.Click
        panelConfiguracion.Visible = False
        Panel1.Visible = False
        If sonidohab Then
            play1.Play()
        End If
    End Sub
    Private Sub cerrarconf_button_MouseDown(sender As Object, e As EventArgs) Handles cerrarconf_button.MouseDown
        cerrarconf_button.BackgroundImage = salir_press
    End Sub
    Private Sub cerrarconf_button_MouseLeave(sender As Object, e As EventArgs) Handles cerrarconf_button.MouseLeave
        cerrarconf_button.BackgroundImage = salir_normal
    End Sub
    Private Sub cerrarconf_button_MouseMove(sender As Object, e As EventArgs) Handles cerrarconf_button.MouseMove
        cerrarconf_button.BackgroundImage = salir_foc
    End Sub
    ''guardarp_button
    Private Sub cargarp_button_Click(sender As Object, e As EventArgs) Handles guardarp_button.Click
        Dim dineroDeJugadoresColl As Collection = New Collection()
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName() = Nothing Or SaveFileDialog1.FileName() = "" Then
        Else
            For i = 1 To numeroJugadoresIniciales
                dineroDeJugadoresColl.Add(jugadores(i).getDinero())
            Next
            _guardarcargar.setDatos(numeroJugadoresIniciales, dineroInicial, apuestaMinima, doblarRegla, meta, dineroDeJugadoresColl)
            _guardarcargar.escribirArchivo(SaveFileDialog1.FileName())
            SaveFileDialog1.FileName = Nothing
        End If
    End Sub
    Private Sub cargarp_buttonn_MouseDown(sender As Object, e As EventArgs) Handles guardarp_button.MouseDown
        guardarp_button.BackgroundImage = guardarp_press
    End Sub
    Private Sub cargarp_button_MouseLeave(sender As Object, e As EventArgs) Handles guardarp_button.MouseLeave
        guardarp_button.BackgroundImage = guardarp_normal
    End Sub
    Private Sub cargarp_button_MouseMove(sender As Object, e As EventArgs) Handles guardarp_button.MouseMove
        guardarp_button.BackgroundImage = guardarp_foc
    End Sub
    ''si_button
    Private Sub si_button_Click(sender As Object, e As EventArgs) Handles si_button.Click
        Form1.Show()
        Form1.ocultarPanelJuego()
        Me.Hide()
    End Sub
    Private Sub si_button_MouseDown(sender As Object, e As EventArgs) Handles si_button.MouseDown
        si_button.BackgroundImage = si_press
    End Sub
    Private Sub si_button_MouseLeave(sender As Object, e As EventArgs) Handles si_button.MouseLeave
        si_button.BackgroundImage = si_normal
    End Sub
    Private Sub si_button_MouseMove(sender As Object, e As EventArgs) Handles si_button.MouseMove
        si_button.BackgroundImage = si_foc
    End Sub
    ''no_button
    Private Sub no_button_Click(sender As Object, e As EventArgs) Handles no_button.Click
        panelConfirmacion.Visible = False
        Panel1.Visible = False
        If sonidohab Then
            play1.Play()
        End If
    End Sub
    Private Sub no_button_MouseDown(sender As Object, e As EventArgs) Handles no_button.MouseDown
        no_button.BackgroundImage = no_press
    End Sub
    Private Sub no_button_MouseLeave(sender As Object, e As EventArgs) Handles no_button.MouseLeave
        no_button.BackgroundImage = no_normal
    End Sub
    Private Sub no_button_MouseMove(sender As Object, e As EventArgs) Handles no_button.MouseMove
        no_button.BackgroundImage = no_foc
    End Sub
    ''musica_button
    Private Sub musica_button_Click(sender As Object, e As EventArgs) Handles musica_button.Click
        If musichab Then
            musica_button.BackgroundImage = musica_nohab_foc
            Form1.AxWindowsMediaPlayer1.Ctlcontrols.stop()
            musichab = False
            Form1.setMusicaHabilitado(False)
        Else
            musica_button.BackgroundImage = musica_hab_foc
            Form1.AxWindowsMediaPlayer1.Ctlcontrols.play()
            musichab = True
            Form1.setMusicaHabilitado(True)
        End If
    End Sub
    Private Sub musica_button_MouseLeave(sender As Object, e As EventArgs) Handles musica_button.MouseLeave
        If musichab Then
            musica_button.BackgroundImage = musica_hab_normal
        Else
            musica_button.BackgroundImage = musica_nohab_normal
        End If
    End Sub
    Private Sub musica_button_MouseMove(sender As Object, e As EventArgs) Handles musica_button.MouseMove
        If musichab Then
            musica_button.BackgroundImage = musica_hab_foc
        Else
            musica_button.BackgroundImage = musica_nohab_foc
        End If
    End Sub
    ''sonido_button
    Private Sub sonido_button_Click(sender As Object, e As EventArgs) Handles sonido_button.Click
        If sonidohab Then
            sonido_button.BackgroundImage = sonido_nohab_foc
            sonidohab = False
            Form1.setSonidoHabilitado(False)
        Else
            sonido_button.BackgroundImage = sonido_hab_foc
            sonidohab = True
            Form1.setSonidoHabilitado(True)
        End If
    End Sub
    Private Sub sonido_button_MouseLeave(sender As Object, e As EventArgs) Handles sonido_button.MouseLeave
        If sonidohab Then
            sonido_button.BackgroundImage = sonido_hab_normal
        Else
            sonido_button.BackgroundImage = sonido_nohab_normal
        End If
    End Sub
    Private Sub sonido_button_MouseMove(sender As Object, e As EventArgs) Handles sonido_button.MouseMove
        If sonidohab Then
            sonido_button.BackgroundImage = sonido_hab_foc
        Else
            sonido_button.BackgroundImage = sonido_nohab_foc
        End If
    End Sub
    ''seguro_button
    Private Sub seguro_button_Click(sender As Object, e As EventArgs) Handles seguro_button.Click
        jugadores(jugadorActual).seguro = True
        seguro_button.Visible = False
    End Sub
    Private Sub seguro_button_MouseDown(sender As Object, e As EventArgs) Handles seguro_button.MouseDown
        seguro_button.BackgroundImage = seg_press
    End Sub
    Private Sub seguro_button_MouseLeave(sender As Object, e As EventArgs) Handles seguro_button.MouseLeave
        seguro_button.BackgroundImage = seg_normal
    End Sub
    Private Sub seguro_button_MouseMove(sender As Object, e As EventArgs) Handles seguro_button.MouseMove
        seguro_button.BackgroundImage = seg_foc
    End Sub

    ''doblarmano_button
    Private Sub doblarmano_button_Click(sender As Object, e As EventArgs) Handles doblarmano_button.Click
    End Sub
    Private Sub doblarmano_button_MouseDown(sender As Object, e As EventArgs) Handles doblarmano_button.MouseDown
        doblarmano_button.BackgroundImage = doblarmano_press
    End Sub
    Private Sub doblarmano_button_MouseLeave(sender As Object, e As EventArgs) Handles doblarmano_button.MouseLeave
        doblarmano_button.BackgroundImage = doblarmano_normal
    End Sub
    Private Sub doblarmano_button_MouseMove(sender As Object, e As EventArgs) Handles doblarmano_button.MouseMove
        doblarmano_button.BackgroundImage = doblarmano_foc
    End Sub
    ''doblar_button
    Private Sub doblar_button_Click(sender As Object, e As EventArgs) Handles doblar_button.Click
        doblar_button.Visible = False
        dineroapostado(jugadorActual).Text = jugadores(jugadorActual).getApuestaActual() * 2
        jugadores(jugadorActual).setApuestaActual(jugadores(jugadorActual).getApuestaActual() * 2)
        Select Case jugadorActual
            Case 1
                mazoJugador1()
                repartirNuevaCarta()
            Case 2
                mazoJugador2()
                repartirNuevaCarta()
            Case 3
                mazoJugador3()
                repartirNuevaCarta()
            Case 4
                mazoJugador4()
                repartirNuevaCarta()
            Case 5
                mazoJugador5()
                repartirNuevaCarta()
        End Select
        If jugadores(jugadorActual).getPuntuacion > 21 And jugadores(jugadorActual).getPuntuacionSecundaria() > 21 Then
            winlose(jugadorActual).Visible = True
            winlose(jugadorActual).BringToFront()
            jugadores(jugadorActual).lose = True
        End If
        siguienteTurno()
        If jugadorActual < numeroJugadores + 1 Then
            mensaje.Text = "Turno JUGADOR " & jugadorActual
            If cartaAScrupier Then
                seguro_button.Visible = True
            End If
            If ((jugadores(jugadorActual).getPuntuacion = 9 Or jugadores(jugadorActual).getPuntuacion = 10 Or jugadores(jugadorActual).getPuntuacion = 11) Or (doblarRegla = False)) And (jugadores(jugadorActual).getDinero() >= (jugadores(jugadorActual).getPuntuacion() * 2)) And (jugadores(jugadorActual).getPuntuacionSecundaria() <> 21) Then
                doblar_button.Visible = True
            Else
                doblar_button.Visible = False
            End If
        End If
        If jugadorActual - 1 = numeroJugadores Then
            etapaPaga()
        End If
    End Sub
    Private Sub doblar_button_MouseDown(sender As Object, e As EventArgs) Handles doblar_button.MouseDown
        doblar_button.BackgroundImage = doblar_press
    End Sub
    Private Sub doblar_button_MouseLeave(sender As Object, e As EventArgs) Handles doblar_button.MouseLeave
        doblar_button.BackgroundImage = doblar_normal
    End Sub
    Private Sub doblar_button_MouseMove(sender As Object, e As EventArgs) Handles doblar_button.MouseMove
        doblar_button.BackgroundImage = doblar_foc
    End Sub
    ''pedircarta_button
    Private Sub pedircarta_button_Click(sender As Object, e As EventArgs) Handles pedircarta_button.Click
        Dim jugadorActualSecundario = jugadorActual
        doblar_button.Visible = False
        Dim masDeV As Boolean = False
        Select Case jugadorActual
            Case 1
                mazoJugador1()
                repartirNuevaCarta()
            Case 2
                mazoJugador2()
                repartirNuevaCarta()
            Case 3
                mazoJugador3()
                repartirNuevaCarta()
            Case 4
                mazoJugador4()
                repartirNuevaCarta()
            Case 5
                mazoJugador5()
                repartirNuevaCarta()
        End Select
        If jugadores(jugadorActual).getPuntuacion > 21 And jugadores(jugadorActual).getPuntuacionSecundaria() > 21 Then
            winlose(jugadorActual).Visible = True
            winlose(jugadorActual).BringToFront()
            jugadores(jugadorActual).lose = True
            siguienteTurno()
            doblar_button.Visible = False
            If cartaAScrupier Then
                seguro_button.Visible = True
            End If
            masDeV = True
        End If
        If masDeV Then
        Else
            If jugadores(jugadorActual).getCantidadCartasActuales = 5 Then
                siguienteTurno()
            End If
        End If
        If jugadorActual < numeroJugadores + 1 Then
            mensaje.Text = "Turno JUGADOR " & jugadorActual
            If ((jugadores(jugadorActual).getPuntuacion = 9 Or jugadores(jugadorActual).getPuntuacion = 10 Or jugadores(jugadorActual).getPuntuacion = 11) Or (doblarRegla = False)) And (jugadores(jugadorActual).getDinero() >= (jugadores(jugadorActual).getPuntuacion() * 2)) And (jugadores(jugadorActual).getPuntuacionSecundaria() <> 21) And (jugadorActualSecundario <> jugadorActual) Then
                doblar_button.Visible = True
            Else
                doblar_button.Visible = False
            End If
        End If
        If jugadorActual - 1 = numeroJugadores Then
            etapaPaga()
        End If
    End Sub
    Private Sub pedircarta_button_MouseDown(sender As Object, e As EventArgs) Handles pedircarta_button.MouseDown
        pedircarta_button.BackgroundImage = pedirc_press
    End Sub
    Private Sub pedircarta_button_MouseLeave(sender As Object, e As EventArgs) Handles pedircarta_button.MouseLeave
        pedircarta_button.BackgroundImage = pedirc_normal
    End Sub
    Private Sub pedircarta_button_MouseMove(sender As Object, e As EventArgs) Handles pedircarta_button.MouseMove
        pedircarta_button.BackgroundImage = pedirc_foc
    End Sub
    ''plantarse_button
    Private Sub plantarse_button_Click(sender As Object, e As EventArgs) Handles plantarse_button.Click
        siguienteTurno()
        If jugadorActual < numeroJugadores + 1 Then
            mensaje.Text = "Turno JUGADOR " & jugadorActual
            If cartaAScrupier Then
                seguro_button.Visible = True
            End If
            If ((jugadores(jugadorActual).getPuntuacion = 9 Or jugadores(jugadorActual).getPuntuacion = 10 Or jugadores(jugadorActual).getPuntuacion = 11) Or (doblarRegla = False)) And (jugadores(jugadorActual).getDinero() >= (jugadores(jugadorActual).getPuntuacion() * 2)) And (jugadores(jugadorActual).getPuntuacionSecundaria() <> 21) Then
                doblar_button.Visible = True
            Else
                doblar_button.Visible = False
            End If
        End If
        If jugadorActual - 1 = numeroJugadores Then
            etapaPaga()
        End If
    End Sub
    Private Sub plantarse_button_MouseDown(sender As Object, e As EventArgs) Handles plantarse_button.MouseDown
        plantarse_button.BackgroundImage = plan_press
    End Sub
    Private Sub plantarse_button_MouseLeave(sender As Object, e As EventArgs) Handles plantarse_button.MouseLeave
        plantarse_button.BackgroundImage = plan_normal
    End Sub
    Private Sub plantarse_button_MouseMove(sender As Object, e As EventArgs) Handles plantarse_button.MouseMove
        plantarse_button.BackgroundImage = plan_foc
    End Sub
    ''apos_button
    Private Sub apos_button_Click(sender As Object, e As EventArgs) Handles apos_button.Click
        If jugadorActual >= numeroJugadores Then
            apos_button.Visible = False
            reiniap_button.Visible = False
            etapaReparticion()
        End If
        siguienteTurno()
        If jugadorActual < numeroJugadores + 1 Then
            mensaje.Text = "Apuesta JUGADOR " & jugadorActual
        End If
    End Sub
    Private Sub apos_button_MouseDown(sender As Object, e As EventArgs) Handles apos_button.MouseDown
        apos_button.BackgroundImage = apos_press
    End Sub
    Private Sub apos_button_MouseMove(sender As Object, e As EventArgs) Handles apos_button.MouseMove
        apos_button.BackgroundImage = apos_foc
    End Sub
    Private Sub apos_button_MouseLeave(sender As Object, e As EventArgs) Handles apos_button.MouseLeave
        apos_button.BackgroundImage = apos_normal
    End Sub
    ''reiniap_button
    Private Sub reiniap_button_Click(sender As Object, e As EventArgs) Handles reiniap_button.Click
        jugadores(jugadorActual).setApuestaActual(apuestaMinima)
        dineroapostado(jugadorActual).Text = apuestaMinima
    End Sub
    Private Sub reiniap_button_MouseDown(sender As Object, e As EventArgs) Handles reiniap_button.MouseDown
        reiniap_button.BackgroundImage = reiniap_press
    End Sub
    Private Sub reiniap_button_MouseMove(sender As Object, e As EventArgs) Handles reiniap_button.MouseMove
        reiniap_button.BackgroundImage = reiniap_foc
    End Sub
    Private Sub reiniap_button_MouseLeave(sender As Object, e As EventArgs) Handles reiniap_button.MouseLeave
        reiniap_button.BackgroundImage = reiniap_normal
    End Sub
    ''siguiente_button
    Private Sub siguiente_button_Click(sender As Object, e As EventArgs) Handles siguiente_button.Click
        For i = 1 To numeroJugadores
            If jugadores(i).haPerdido Then
                dineroapostado(i).Visible = False
                numerojugador(i).Visible = False
                punteojugadores(i).Visible = False
                panelpunteojugadores(i).Visible = False
                panelinfjugadores(i).BackgroundImage = panelloser
                panelinfjugadores(i).BringToFront()
                If i = numeroJugadores Then
                    numeroJugadores = numeroJugadores - 1
                    For j = 1 To 5
                        cartasJugadores(i, j).Visible = False
                        cartasJugadores(i, j).BackgroundImage = Nothing
                    Next
                    winlose(i).Visible = False
                End If
            End If
        Next
        reiniciarTurnos()
        siguiente_button.Visible = False
        mensaje.Text = "Apuesta JUGADOR " & jugadorActual
        For i = 1 To numeroJugadores
            jugadores(i).setApuestaActual(apuestaMinima)
            dineroapostado(i).Text = apuestaMinima
            If jugadores(i).haPerdido Then
                dineroapostado(i).Text = False
                jugadores(i).setApuestaActual(0)
            End If
            winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
            winlose(i).Visible = False
        Next
        For i = 0 To numeroJugadores
            For j = 1 To 5
                cartasJugadores(i, j).Visible = False
                cartasJugadores(i, j).BackgroundImage = Nothing
            Next
            For j = 3 To 5
                cartasJugadores(i, j).Visible = False
            Next
            jugadores(i).setPuntuacion(0)
            jugadores(i).setPuntuacionSecundaria(0)
            jugadores(i).setCantidadCartasActuales(0)
            jugadores(i).lose = False
            jugadores(i).blackjack = False
            jugadores(i).seguro = False
            punteojugadores(i).ForeColor = Color.White
            punteojugadores(i).Text = ""
        Next
        ficha5_button.Visible = True
        ficha10_button.Visible = True
        ficha50_button.Visible = True
        ficha100_button.Visible = True
        ficha500_button.Visible = True
        ficha1000_button.Visible = True
        px = 764
        py = 25
        jDA = 1
        vueltas = 1
        apos_button.Visible = True
        reiniap_button.Visible = True
        cartasJugadores(0, 1).BringToFront()
        sepagaSeguro = False
        cartaAScrupier = False
        For i = numeroJugadoresIniciales To 1 Step -1
            If jugadores(i).haPerdido Then
                numeroJugadores = i - 1
            Else
                Exit For
            End If
        Next
    End Sub
    Private Sub siguiente_button_MouseDown(sender As Object, e As EventArgs) Handles siguiente_button.MouseDown
        siguiente_button.BackgroundImage = siguiente_press
    End Sub
    Private Sub siguiente_button_MouseMove(sender As Object, e As EventArgs) Handles siguiente_button.MouseMove
        siguiente_button.BackgroundImage = siguiente_foc
    End Sub
    Private Sub siguiente_button_MouseLeave(sender As Object, e As EventArgs) Handles siguiente_button.MouseLeave
        siguiente_button.BackgroundImage = siguiente_normal
    End Sub
    ''ficha5_button
    Private Sub ficha5_button_Click(sender As Object, e As EventArgs) Handles ficha5_button.Click
        If jugadores(jugadorActual).getApuestaActual() <= jugadores(jugadorActual).getDinero() - 10 Then
            jugadores(jugadorActual).setApuestaActual(jugadores(jugadorActual).getApuestaActual + 10)
            dineroapostado(jugadorActual).Text = jugadores(jugadorActual).getApuestaActual()
        End If
    End Sub
    Private Sub ficha5_button_MouseDown(sender As Object, e As EventArgs) Handles ficha5_button.MouseDown
        ficha5_button.Location = New Point(950, 417)
    End Sub
    Private Sub ficha5_button_MouseUp(sender As Object, e As EventArgs) Handles ficha5_button.MouseUp
        ficha5_button.Location = New Point(950, 415)
    End Sub
    ''ficha10_button
    Private Sub ficha10_button_Click(sender As Object, e As EventArgs) Handles ficha10_button.Click
        If jugadores(jugadorActual).getApuestaActual() <= jugadores(jugadorActual).getDinero() - 100 Then
            jugadores(jugadorActual).setApuestaActual(jugadores(jugadorActual).getApuestaActual + 100)
            dineroapostado(jugadorActual).Text = jugadores(jugadorActual).getApuestaActual()
        End If
    End Sub
    Private Sub ficha10_button_MouseDown(sender As Object, e As EventArgs) Handles ficha10_button.MouseDown
        ficha10_button.Location = New Point(1050, 417)
    End Sub
    Private Sub ficha10_button_MouseUp(sender As Object, e As EventArgs) Handles ficha10_button.MouseUp
        ficha10_button.Location = New Point(1050, 415)
    End Sub
    ''ficha50_button
    Private Sub ficha50_button_Click(sender As Object, e As EventArgs) Handles ficha50_button.Click
        If jugadores(jugadorActual).getApuestaActual() <= jugadores(jugadorActual).getDinero() - 1000 Then
            jugadores(jugadorActual).setApuestaActual(jugadores(jugadorActual).getApuestaActual + 1000)
            dineroapostado(jugadorActual).Text = jugadores(jugadorActual).getApuestaActual()
        End If
    End Sub
    Private Sub ficha50_button_MouseDown(sender As Object, e As EventArgs) Handles ficha50_button.MouseDown
        ficha50_button.Location = New Point(1150, 417)
    End Sub
    Private Sub ficha50_button_MouseUp(sender As Object, e As EventArgs) Handles ficha50_button.MouseUp
        ficha50_button.Location = New Point(1150, 415)
    End Sub
    ''ficha100_button
    Private Sub ficha100_button_Click(sender As Object, e As EventArgs) Handles ficha100_button.Click
        If jugadores(jugadorActual).getApuestaActual() <= jugadores(jugadorActual).getDinero() - 10000 Then
            jugadores(jugadorActual).setApuestaActual(jugadores(jugadorActual).getApuestaActual + 10000)
            dineroapostado(jugadorActual).Text = jugadores(jugadorActual).getApuestaActual()
        End If
    End Sub
    Private Sub ficha100_button_MouseDown(sender As Object, e As EventArgs) Handles ficha100_button.MouseDown
        ficha100_button.Location = New Point(950, 502)
    End Sub
    Private Sub ficha100_button_MouseUp(sender As Object, e As EventArgs) Handles ficha100_button.MouseUp
        ficha100_button.Location = New Point(950, 500)
    End Sub
    ''ficha500_button
    Private Sub ficha500_button_Click(sender As Object, e As EventArgs) Handles ficha500_button.Click
        If jugadores(jugadorActual).getApuestaActual() <= jugadores(jugadorActual).getDinero() - 50000 Then
            jugadores(jugadorActual).setApuestaActual(jugadores(jugadorActual).getApuestaActual + 50000)
            dineroapostado(jugadorActual).Text = jugadores(jugadorActual).getApuestaActual()
        End If
    End Sub
    Private Sub ficha500_button_MouseDown(sender As Object, e As EventArgs) Handles ficha500_button.MouseDown
        ficha500_button.Location = New Point(1050, 502)
    End Sub
    Private Sub ficha500_button_MouseUp(sender As Object, e As EventArgs) Handles ficha500_button.MouseUp
        ficha500_button.Location = New Point(1050, 500)
    End Sub
    ''ficha1000_button
    Private Sub ficha1000_button_Click(sender As Object, e As EventArgs) Handles ficha1000_button.Click
        If jugadores(jugadorActual).getApuestaActual() <= jugadores(jugadorActual).getDinero() - 100000 Then
            jugadores(jugadorActual).setApuestaActual(jugadores(jugadorActual).getApuestaActual + 100000)
            dineroapostado(jugadorActual).Text = jugadores(jugadorActual).getApuestaActual()
        End If
    End Sub
    Private Sub ficha1000_button_MouseDown(sender As Object, e As EventArgs) Handles ficha1000_button.MouseDown
        ficha1000_button.Location = New Point(1150, 502)
    End Sub
    Private Sub ficha1000_button_MouseUp(sender As Object, e As EventArgs) Handles ficha1000_button.MouseUp
        ficha1000_button.Location = New Point(1150, 500)
    End Sub
    ''nuevap_button
    Private Sub nuevap_button_Click(sender As Object, e As EventArgs) Handles nuevap_button.Click
        Form1.Show()
        Form1.mostrarPanelJuego()
        Me.Visible = False
    End Sub
    Private Sub nuevap_button_MouseDown(sender As Object, e As EventArgs) Handles nuevap_button.MouseDown
        nuevap_button.BackgroundImage = nuevapartida_press
    End Sub
    Private Sub nuevap_button_MouseLeave(sender As Object, e As EventArgs) Handles nuevap_button.MouseLeave
        nuevap_button.BackgroundImage = nuevapartida_normal
    End Sub
    Private Sub nuevap_button_MouseMove(sender As Object, e As EventArgs) Handles nuevap_button.MouseMove
        nuevap_button.BackgroundImage = nuevapartida_foc
    End Sub


    'Getters y Setters
    Public Sub setDineroInicial(dineroInicial As Integer)
        Me.dineroInicial = dineroInicial
    End Sub
    Public Sub setNumeroJugadores(numeroJugadores As Integer)
        Me.numeroJugadores = numeroJugadores
        numeroJugadoresIniciales = numeroJugadores
        If numeroJugadores = 1 Then
            multijugador = False
        Else
            multijugador = True
        End If
    End Sub
    Public Sub setApuestaMinima(apuestaMinima As Integer)
        Me.apuestaMinima = apuestaMinima
    End Sub
    Public Sub setMeta(meta As Integer)
        Me.meta = meta
    End Sub
    Public Sub setDoblarRegla(doblarRegla As Boolean)
        Me.doblarRegla = doblarRegla
    End Sub
    Public Sub setSonidoHabilitado(sonidohabilitado As Boolean)
        sonidohab = sonidohabilitado
        If sonidohabilitado Then
            sonido_button.BackgroundImage = sonido_hab_normal
        Else
            sonido_button.BackgroundImage = sonido_nohab_normal
        End If
    End Sub
    Public Sub setMusicaHabilitado(musicahabilitada As Boolean)
        musichab = musicahabilitada
        If musicahabilitada Then
            musica_button.BackgroundImage = musica_hab_normal
        Else
            musica_button.BackgroundImage = musica_nohab_normal
        End If
    End Sub


    'Otros Metodos
    Private Sub repartirPrimerasDosCartas()
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim valor As Integer = 0
        Dim valorsecundario As Integer = 0
        Dim existeas As Integer = 0
        For i = 0 To numeroJugadores
            existeas = 0
            For j = 1 To 2
                Randomize()
                a = 1 + Int(Rnd() * 4)
                b = 1 + Int(Rnd() * 13)
                valor = b
                valorsecundario = b
                If b > 10 Then
                    valor = 10
                    valorsecundario = 10
                ElseIf b = 1
                    valor = 1
                    valorsecundario = 11
                    existeas = existeas + 1
                End If
                If b = 1 And existeas = 2 Then
                    valor = 1
                    valorsecundario = 1
                End If
                cartasJugadores(i, j).BackgroundImage = cartas(a, b)
                jugadores(i).setPuntuacion(jugadores(i).getPuntuacion() + valor)
                jugadores(i).setPuntuacionSecundaria(jugadores(i).getPuntuacionSecundaria() + valorsecundario)
                If j = 2 And i = 0 Then
                    valorCartaOcultaCrupier = valor
                    valorCartaOcultaSecundario = valorsecundario
                End If
                If j = 1 And i = 0 And b = 1 Then
                    cartaAScrupier = True
                End If
            Next
        Next
    End Sub
    Private Sub repartirNuevaCarta()
        Randomize()
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim valor As Integer = 0
        Dim valorsecundario As Integer = 0
        Dim existeas As Integer = 0
        a = 1 + Int(Rnd() * 4)
        b = 1 + Int(Rnd() * 13)
        valor = b
        valorsecundario = b
        If b > 10 Then
            valor = 10
            valorsecundario = 10
        ElseIf b = 1
            valor = 1
            valorsecundario = 11
            existeas = existeas + 1
        End If
        If b = 1 And existeas = 2 Then
            valor = 1
            valorsecundario = 1
        End If
        cartasJugadores(jugadorActual, jugadores(jugadorActual).getCantidadCartasActuales() + 1).BackgroundImage = cartas(a, b)
        jugadores(jugadorActual).setPuntuacion(jugadores(jugadorActual).getPuntuacion() + valor)
        jugadores(jugadorActual).setPuntuacionSecundaria(jugadores(jugadorActual).getPuntuacionSecundaria() + valorsecundario)
        jugadores(jugadorActual).setCantidadCartasActuales(jugadores(jugadorActual).getCantidadCartasActuales() + 1)
        punteojugadores(jugadorActual).Text = jugadores(jugadorActual).mostrarPuntuacion()
    End Sub

    Private Sub repartirNuevaCrupier()
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim valor As Integer = 0
        Dim valorsecundario As Integer = 0
        Dim existeas As Integer = 0
        Randomize()
        a = 1 + Int(Rnd() * 4)
        b = 1 + Int(Rnd() * 13)
        valor = b
        valorsecundario = b
        If b > 10 Then
            valor = 10
            valorsecundario = 10
        ElseIf b = 1
            valor = 1
            valorsecundario = 11
            existeas = existeas + 1
        End If
        If b = 1 And existeas = 2 Then
            valor = 1
            valorsecundario = 1
        End If
        cartasJugadores(0, jugadores(0).getCantidadCartasActuales() + 1).BackgroundImage = cartas(a, b)
        jugadores(0).setPuntuacion(jugadores(0).getPuntuacion() + valor)
        jugadores(0).setPuntuacionSecundaria(jugadores(0).getPuntuacionSecundaria() + valorsecundario)
        jugadores(0).setCantidadCartasActuales(jugadores(0).getCantidadCartasActuales() + 1)
        punteojugadores(0).Text = jugadores(0).mostrarPuntuacion()
    End Sub

    Private Sub etapaReparticion()
        ficha1000_button.Visible = False
        ficha500_button.Visible = False
        ficha100_button.Visible = False
        ficha50_button.Visible = False
        ficha10_button.Visible = False
        ficha5_button.Visible = False
        repartirPrimerasDosCartas()
        reiniciarTurnosAnimaciones()
        todosLosMazos()
    End Sub

    Private Sub etapaAccionJugador()
        pedircarta_button.Visible = True
        plantarse_button.Visible = True
        If cartaAScrupier Then
            seguro_button.Visible = True
        End If
        If ((jugadores(jugadorActual).getPuntuacion = 9 Or jugadores(jugadorActual).getPuntuacion = 10 Or jugadores(jugadorActual).getPuntuacion = 11) Or (doblarRegla = False)) And (jugadores(jugadorActual).getDinero() >= (jugadores(jugadorActual).getPuntuacion() * 2)) And (jugadores(jugadorActual).getPuntuacionSecundaria() <> 21) Then
            doblar_button.Visible = True
        End If
    End Sub

    Private Sub etapaPaga()
        pedircarta_button.Visible = False
        plantarse_button.Visible = False
        doblar_button.Visible = False
        doblarmano_button.Visible = False
        seguro_button.Visible = False
        mensaje.Text = ""
        jugadores(0).setCantidadCartasActuales(2)
        cartasJugadores(0, 2).BackgroundImage = cartaOcultaCrupier
        cartasJugadores(0, 2).BringToFront()
        punteojugadores(0).Text = jugadores(0).mostrarPuntuacion
        timer7.Start()
    End Sub

    Private Sub darCartasCrupier()
        repartirNuevaCrupier()
        mazoCrupier()
        timer7.Start()
    End Sub
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles timer7.Tick
        timer7.Stop()
        If jugadores(0).darMejorPuntuacion() < 17 And jugadores(0).getCantidadCartasActuales() < 5 Then
            darCartasCrupier()
        Else
            comprobarGanadores()
        End If
    End Sub

    Private Sub comprobarGanadores()
        Dim jugadorConMasDinero As Integer = 0
        Dim existeEmpate As Boolean = False
        Dim dineroMayor As Integer = 0
        Dim queda1 As Boolean = False
        Dim todosPerdieron As Boolean = False
        Dim conteoJugadores As Integer = 0
        Dim ganadores As String = "HAN GANADO LOS JUGADORES: "
        For i = 1 To numeroJugadores
            If jugadores(i).haPerdido Then
            Else
                dineroapostado(i).Text = "0"
                If jugadores(i).seguro Then
                    If sepagaSeguro Then
                        jugadores(i).setDinero(Int(jugadores(i).getApuestaActual() / 2) + jugadores(i).getDinero())
                    Else
                        jugadores(i).setDinero(jugadores(i).getDinero() - Int(jugadores(i).getApuestaActual() / 2))
                    End If
                End If
                If jugadores(i).lose Then
                    punteojugadores(i).ForeColor = Color.Red
                    punteojugadores(i).Text = "-" & (jugadores(i).getApuestaActual())
                    jugadores(i).setDinero(jugadores(i).getDinero() - (jugadores(i).getApuestaActual()))
                Else
                    If jugadores(i).darMejorPuntuacion() <= 21 And jugadores(0).darMejorPuntuacion() < jugadores(i).darMejorPuntuacion() And (jugadores(i).blackjack = False) Then
                        winlose(i).BringToFront()
                        winlose(i).Visible = True
                        winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.win
                        jugadores(i).setDinero((jugadores(i).getApuestaActual()) + jugadores(i).getDinero())
                        punteojugadores(i).ForeColor = Color.Green
                        punteojugadores(i).Text = "+" & (jugadores(i).getApuestaActual())
                    ElseIf jugadores(i).darMejorPuntuacion() = jugadores(0).darMejorPuntuacion()
                        winlose(i).Visible = True
                        winlose(i).BringToFront()
                        winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.draw
                        punteojugadores(i).Text = ""
                    ElseIf jugadores(i).blackjack
                        winlose(i).Visible = True
                        winlose(i).BringToFront()
                        winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.win
                        jugadores(i).setDinero(Int(jugadores(i).getApuestaActual() * (3 / 2)) + jugadores(i).getDinero())
                        punteojugadores(i).ForeColor = Color.Green
                        punteojugadores(i).Text = "+" & (jugadores(i).getApuestaActual() * (3 / 2))
                    ElseIf jugadores(0).darMejorPuntuacion() > 21
                        winlose(i).BringToFront()
                        winlose(i).Visible = True
                        winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.win
                        jugadores(i).setDinero((jugadores(i).getApuestaActual()) + jugadores(i).getDinero())
                        punteojugadores(i).ForeColor = Color.Green
                        punteojugadores(i).Text = "+" & (jugadores(i).getApuestaActual())
                    Else
                        winlose(i).Visible = True
                        winlose(i).BringToFront()
                        winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
                        punteojugadores(i).ForeColor = Color.Red
                        jugadores(i).setDinero(jugadores(i).getDinero() - (jugadores(i).getApuestaActual()))
                        punteojugadores(i).Text = "-" & (jugadores(i).getApuestaActual())
                    End If
                End If
                dinerojugadores(i).Text = jugadores(i).getDinero()
            End If
        Next
        For i = 1 To numeroJugadores
            If (jugadores(i).getDinero() < apuestaMinima) Or (jugadores(i).getDinero() = 0) Then
                jugadores(i).haPerdido = True
            End If
        Next
        For i = 1 To numeroJugadoresIniciales
            If jugadores(i).haPerdido Then
                conteoJugadores = conteoJugadores + 1
            End If
        Next
        If conteoJugadores = numeroJugadoresIniciales Then
            If multijugador Then
                mensaje2.Text = "TODOS PIERDEN"
                If sonidohab Then
                    play2.Play()
                End If
            Else
                mensaje2.Text = "HA PERDIDO"
                If sonidohab Then
                    play2.Play()
                End If
            End If
            nuevap_button.Visible = True
        ElseIf numeroJugadoresIniciales - conteoJugadores = 1 And multijugador = True
            reiniciarTurnos()
            mensaje2.Text = "HA GANADO EL JUGADOR " & " " & jugadorActual
            nuevap_button.Visible = True
        Else
            For i = 1 To numeroJugadoresIniciales
                If jugadores(i).getDinero() > dineroMayor Then
                    dineroMayor = jugadores(i).getDinero()
                    jugadorConMasDinero = i
                End If
            Next
            If jugadores(jugadorConMasDinero).getDinero() >= meta Then
                For i = 1 To numeroJugadoresIniciales
                    If jugadorConMasDinero = i Then
                    Else
                        If jugadores(jugadorConMasDinero).getDinero() = jugadores(i).getDinero() Then
                            existeEmpate = True
                            ganadores = ganadores & " " & i
                            nuevap_button.Visible = True
                        End If
                    End If
                Next
                If existeEmpate Then
                    mensaje2.Text = ganadores
                Else
                    mensaje2.Text = "HA GANADO EL JUGADOR" & jugadorConMasDinero
                    nuevap_button.Visible = True
                End If
            Else
                siguiente_button.Visible = True
            End If
        End If
    End Sub

    Private Sub siguienteTurno()
        Dim valido As Boolean = True
        While valido
            jugadorActual = jugadorActual + 1
            If jugadorActual <= numeroJugadores Then
                If jugadores(jugadorActual).haPerdido Then
                Else
                    valido = False
                End If
            Else
                valido = False
            End If
        End While
        Select Case jugadorActual
            Case 1
                arrow_img.Location = New Point(900, 75)
            Case 2
                If numeroJugadoresIniciales >= 2 Then
                    arrow_img.Location = New Point(900, 140)
                End If
            Case 3
                If numeroJugadoresIniciales >= 3 Then
                    arrow_img.Location = New Point(900, 205)
                End If
            Case 4
                If numeroJugadoresIniciales >= 4 Then
                    arrow_img.Location = New Point(900, 270)
                End If
            Case 5
                If numeroJugadoresIniciales >= 5 Then
                    arrow_img.Location = New Point(900, 335)
                End If
        End Select
    End Sub

    Private Sub siguienteTurnoAnimaciones()
        Dim valido As Boolean = True
        While valido
            jDA = jDA + 1
            If jDA <= numeroJugadores Then
                If jugadores(jDA).haPerdido Then
                Else
                    valido = False
                End If
            Else
                valido = False
            End If
        End While
    End Sub

    Private Sub reiniciarTurnosAnimaciones()
        Dim valido As Boolean = True
        jDA = 1
        While valido
            If jugadores(jDA).haPerdido Then
                jDA = jDA + 1
            Else
                valido = False
            End If
        End While
    End Sub

    Private Sub reiniciarTurnos()
        Dim valido As Boolean = True
        jugadorActual = 1
        While valido
            If jugadores(jugadorActual).haPerdido Then
                jugadorActual = jugadorActual + 1
            Else
                valido = False
            End If
        End While
        Select Case jugadorActual
            Case 1
                arrow_img.Location = New Point(900, 75)
            Case 2
                arrow_img.Location = New Point(900, 140)
            Case 3
                arrow_img.Location = New Point(900, 205)
            Case 4
                arrow_img.Location = New Point(900, 270)
            Case 5
                arrow_img.Location = New Point(900, 335)
        End Select
    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ''Animaciones
    Dim px As Integer = 764
    Dim py As Integer = 25
    Dim jDA As Integer = 1
    Dim vueltas As Integer = 1
    Private Sub mazoCrupier()
        If px > 511 Then
            px = px - 50
            py = Int((0.009 * px) + 25)
            cartaVolteada.Location = New Point(px, py)
            timer0.Start()
        Else
            px = 764
            py = 25
            cartaVolteada.Location = New Point(764, 25)
            cartasJugadores(0, jugadores(0).getCantidadCartasActuales()).Visible = True
            cartasJugadores(0, jugadores(0).getCantidadCartasActuales()).BringToFront()
        End If
    End Sub
    Private Sub Timer0_Tick(sender As Object, e As EventArgs) Handles timer0.Tick
        timer0.Stop()
        mazoCrupier()
    End Sub
    Private Sub mazoJugador5()
        If px > 184 Then
            px = px - 75
            py = Int((-0.288 * px) + 245.212)
            cartaVolteada.Location = New Point(px, py)
            timer5.Start()
        Else
            px = 764
            py = 25
            cartaVolteada.Location = New Point(764, 25)
            cartasJugadores(5, jugadores(5).getCantidadCartasActuales()).Visible = True
            cartasJugadores(5, jugadores(5).getCantidadCartasActuales()).BringToFront()
        End If
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles timer5.Tick
        timer5.Stop()
        mazoJugador5()
    End Sub
    Private Sub mazoJugador4()
        If px > 740 Then
            px = px - 14
            py = Int((-5.282 * px) + 4060.487)
            cartaVolteada.Location = New Point(px, py)
            timer4.Start()
        Else
            px = 764
            py = 25
            cartaVolteada.Location = New Point(764, 25)
            cartasJugadores(4, jugadores(4).getCantidadCartasActuales()).Visible = True
            cartasJugadores(4, jugadores(4).getCantidadCartasActuales()).BringToFront()
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles timer4.Tick
        timer4.Stop()
        mazoJugador4()
    End Sub
    Private Sub mazoJugador3()
        If px > 328 Then
            px = px - 50
            py = Int((-0.567 * px) + 458.313)
            cartaVolteada.Location = New Point(px, py)
            timer3.Start()
        Else
            px = 764
            py = 25
            cartaVolteada.Location = New Point(764, 25)
            cartasJugadores(3, jugadores(3).getCantidadCartasActuales()).Visible = True
            cartasJugadores(3, jugadores(3).getCantidadCartasActuales()).BringToFront()
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles timer3.Tick
        timer3.Stop()
        mazoJugador3()
    End Sub
    Private Sub mazoJugador2()
        If px > 625 Then
            px = px - 35
            py = Int((-1.727 * px) + 1344.636)
            cartaVolteada.Location = New Point(px, py)
            timer2.Start()
        Else
            px = 764
            py = 25
            cartaVolteada.Location = New Point(764, 25)
            cartasJugadores(2, jugadores(2).getCantidadCartasActuales()).Visible = True
            cartasJugadores(2, jugadores(2).getCantidadCartasActuales()).BringToFront()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        timer2.Stop()
        mazoJugador2()
    End Sub
    Private Sub mazoJugador1()
        If px > 511 Then
            px = px - 50
            py = Int((-0.952 * px) + 752.21)
            cartaVolteada.Location = New Point(px, py)
            timer1.Start()
        Else
            px = 764
            py = 25
            cartaVolteada.Location = New Point(764, 25)
            cartasJugadores(1, jugadores(1).getCantidadCartasActuales()).Visible = True
            cartasJugadores(1, jugadores(1).getCantidadCartasActuales()).BringToFront()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        timer1.Stop()
        mazoJugador1()
    End Sub

    Private Sub todosLosMazos()
        Select Case jDA
            Case 1
                If px > 511 Then
                    px = px - 50
                    py = Int((-0.952 * px) + 752.21)
                    cartaVolteada.Location = New Point(px, py)
                    timer6.Start()
                Else
                    px = 764
                    py = 25
                    cartaVolteada.Location = New Point(764, 25)
                    cartasJugadores(1, jugadores(1).getCantidadCartasActuales() + 1).Visible = True
                    cartasJugadores(1, jugadores(1).getCantidadCartasActuales() + 1).BringToFront()
                    jugadores(1).setCantidadCartasActuales(jugadores(1).getCantidadCartasActuales() + 1)
                    siguienteTurnoAnimaciones()
                    timer6.Start()
                    If jDA = numeroJugadores + 1 Then
                        vueltas = vueltas + 1
                        reiniciarTurnosAnimaciones()
                    End If
                End If
            Case 2
                If px > 625 Then
                    px = px - 35
                    py = Int((-1.727 * px) + 1344.636)
                    cartaVolteada.Location = New Point(px, py)
                    timer6.Start()
                Else
                    px = 764
                    py = 25
                    cartaVolteada.Location = New Point(764, 25)
                    cartasJugadores(2, jugadores(2).getCantidadCartasActuales() + 1).Visible = True
                    cartasJugadores(2, jugadores(2).getCantidadCartasActuales() + 1).BringToFront()
                    jugadores(2).setCantidadCartasActuales(jugadores(2).getCantidadCartasActuales() + 1)
                    siguienteTurnoAnimaciones()
                    timer6.Start()
                    If jDA = numeroJugadores + 1 Then
                        vueltas = vueltas + 1
                        reiniciarTurnosAnimaciones()
                    End If
                End If
            Case 3
                If px > 328 Then
                    px = px - 50
                    py = Int((-0.567 * px) + 458.313)
                    cartaVolteada.Location = New Point(px, py)
                    timer6.Start()
                Else
                    px = 764
                    py = 25
                    cartaVolteada.Location = New Point(764, 25)
                    cartasJugadores(3, jugadores(3).getCantidadCartasActuales() + 1).Visible = True
                    cartasJugadores(3, jugadores(3).getCantidadCartasActuales() + 1).BringToFront()
                    jugadores(3).setCantidadCartasActuales(jugadores(3).getCantidadCartasActuales() + 1)
                    siguienteTurnoAnimaciones()
                    timer6.Start()
                    If jDA = numeroJugadores + 1 Then
                        vueltas = vueltas + 1
                        reiniciarTurnosAnimaciones()
                    End If
                End If
            Case 4
                If px > 740 Then
                    px = px - 14
                    py = Int((-5.282 * px) + 4060.487)
                    cartaVolteada.Location = New Point(px, py)
                    timer6.Start()
                Else
                    px = 764
                    py = 25
                    cartaVolteada.Location = New Point(764, 25)
                    cartasJugadores(4, jugadores(4).getCantidadCartasActuales() + 1).Visible = True
                    cartasJugadores(4, jugadores(4).getCantidadCartasActuales() + 1).BringToFront()
                    jugadores(4).setCantidadCartasActuales(jugadores(4).getCantidadCartasActuales() + 1)
                    siguienteTurnoAnimaciones()
                    timer6.Start()
                    If jDA = numeroJugadores + 1 Then
                        vueltas = vueltas + 1
                        reiniciarTurnosAnimaciones()
                    End If
                End If
            Case 5
                If px > 184 Then
                    px = px - 75
                    py = Int((-0.288 * px) + 245.212)
                    cartaVolteada.Location = New Point(px, py)
                    timer6.Start()
                Else
                    px = 764
                    py = 25
                    cartaVolteada.Location = New Point(764, 25)
                    cartasJugadores(5, jugadores(5).getCantidadCartasActuales() + 1).Visible = True
                    cartasJugadores(5, jugadores(5).getCantidadCartasActuales() + 1).BringToFront()
                    jugadores(5).setCantidadCartasActuales(jugadores(5).getCantidadCartasActuales() + 1)
                    siguienteTurnoAnimaciones()
                    timer6.Start()
                    If jDA = numeroJugadores + 1 Then
                        vueltas = vueltas + 1
                        reiniciarTurnosAnimaciones()
                    End If
                End If
        End Select
    End Sub
    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles timer6.Tick
        timer6.Stop()
        If vueltas < 3 Then
            If jDA < numeroJugadores + 1 Then
                timer6.Stop()
                todosLosMazos()
            End If
        Else
            cartasJugadores(0, 1).Visible = True
            cartaOcultaCrupier = cartasJugadores(0, 2).BackgroundImage
            cartasJugadores(0, 2).BackgroundImage = Global.BlackJack.My.Resources.Resources.reversoCarta
            cartasJugadores(0, 2).Visible = True
            For i = 1 To numeroJugadores
                punteojugadores(i).Text = jugadores(i).mostrarPuntuacion()
            Next
            reiniciarTurnos()
            mensaje.Text = "Turno JUGADOR " & jugadorActual
            etapaAccionJugador()
        End If
    End Sub

    Public Sub reiniciar()
        plantarse_button.Visible = False
        pedircarta_button.Visible = False
        seguro_button.Visible = False
        doblar_button.Visible = False
        panelConfirmacion.Visible = False
        Panel1.Visible = False
        panelConfiguracion.Visible = False
        For i = 1 To numeroJugadores
            panelinfjugadores(i).Visible = False
            panelpunteojugadores(i).Visible = False
            dineroapostado(i).Visible = False
            dinerojugadores(i).Visible = False
            winlose(i).Visible = False
            numerojugador(i).Visible = False
            For j = 1 To 5
                cartasJugadores(i, j).Visible = False
                cartasJugadores(i, j).BackgroundImage = Nothing
            Next
        Next
        IniciarComponentesDeJugadores()
        For i = 1 To numeroJugadores
            jugadores(i) = New Jugador
            jugadores(i).setDinero(dineroInicial)
            jugadores(i).setApuestaActual(apuestaMinima)
        Next
        reiniciarTurnos()
        siguiente_button.Visible = False
        mensaje.Text = "Apuesta JUGADOR " & jugadorActual
        For i = 1 To numeroJugadores
            jugadores(i).setApuestaActual(apuestaMinima)
            dineroapostado(i).Text = apuestaMinima
            jugadores(i).setDinero(dineroInicial)
            dinerojugadores(i).Text = dineroInicial
            If jugadores(i).haPerdido Then
                dineroapostado(i).Text = False
                jugadores(i).setApuestaActual(0)
            End If
            winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
            winlose(i).Visible = False
        Next
        For i = 0 To numeroJugadores
            For j = 1 To 5
                cartasJugadores(i, j).Visible = False
                cartasJugadores(i, j).BackgroundImage = Nothing
            Next
            For j = 3 To 5
                cartasJugadores(i, j).Visible = False
            Next
            jugadores(i).setPuntuacion(0)
            jugadores(i).setPuntuacionSecundaria(0)
            jugadores(i).setCantidadCartasActuales(0)
            jugadores(i).lose = False
            jugadores(i).blackjack = False
            jugadores(i).seguro = False
            punteojugadores(i).ForeColor = Color.White
            punteojugadores(i).Text = ""
        Next
        ficha5_button.Visible = True
        ficha10_button.Visible = True
        ficha50_button.Visible = True
        ficha100_button.Visible = True
        ficha500_button.Visible = True
        ficha1000_button.Visible = True
        px = 764
        py = 25
        jDA = 1
        vueltas = 1
        apos_button.Visible = True
        reiniap_button.Visible = True
        cartasJugadores(0, 1).BringToFront()
        sepagaSeguro = False
        cartaAScrupier = False
        For i = 1 To numeroJugadoresIniciales
            jugadores(i).setApuestaActual(apuestaMinima)
        Next
        mensaje2.Text = ""
        nuevap_button.Visible = False
        For i = numeroJugadores + 1 To 5
            panelinfjugadores(i).Visible = False
            panelpunteojugadores(i).Visible = False
            dineroapostado(i).Visible = False
            dinerojugadores(i).Visible = False
            winlose(i).Visible = False
            numerojugador(i).Visible = False
            punteojugadores(i).Visible = False
            For j = 1 To 5
                cartasJugadores(i, j).Visible = False
                cartasJugadores(i, j).BackgroundImage = Nothing
            Next
        Next
    End Sub

    Public Sub setDineroJugadoresCargarPartida(dineroDeLosJugadores As Collection)
        For i = 1 To numeroJugadoresIniciales
            jugadores(i).setDinero(dineroDeLosJugadores.Item(i))
            dinerojugadores(i).Text = jugadores(i).getDinero()
            If jugadores(i).getDinero() = 0 Or jugadores(i).getDinero() < apuestaMinima Then
                jugadores(i).haPerdido = True
                panelinfjugadores(i).BackgroundImage = panelloser
                panelinfjugadores(i).BringToFront()
                panelpunteojugadores(i).Visible = False
                punteojugadores(i).Visible = False
                dineroapostado(i).Visible = False
                numerojugador(i).Visible = False
            End If
        Next
        For i = 1 To numeroJugadores
            If jugadores(i).haPerdido Then
                dineroapostado(i).Visible = False
                numerojugador(i).Visible = False
                punteojugadores(i).Visible = False
                panelpunteojugadores(i).Visible = False
                panelinfjugadores(i).BackgroundImage = panelloser
                panelinfjugadores(i).BringToFront()
                If i = numeroJugadores Then
                    numeroJugadores = numeroJugadores - 1
                    For j = 1 To 5
                        cartasJugadores(i, j).Visible = False
                        cartasJugadores(i, j).BackgroundImage = Nothing
                    Next
                    winlose(i).Visible = False
                End If
            End If
        Next
        reiniciarTurnos()
        siguiente_button.Visible = False
        mensaje.Text = "Apuesta JUGADOR " & jugadorActual
        For i = 1 To numeroJugadores
            jugadores(i).setApuestaActual(apuestaMinima)
            dineroapostado(i).Text = apuestaMinima
            If jugadores(i).haPerdido Then
                dineroapostado(i).Text = False
                jugadores(i).setApuestaActual(0)
            End If
            winlose(i).BackgroundImage = Global.BlackJack.My.Resources.Resources.lose
            winlose(i).Visible = False
        Next
        For i = 0 To numeroJugadores
            For j = 1 To 5
                cartasJugadores(i, j).Visible = False
                cartasJugadores(i, j).BackgroundImage = Nothing
            Next
            For j = 3 To 5
                cartasJugadores(i, j).Visible = False
            Next
            jugadores(i).setPuntuacion(0)
            jugadores(i).setPuntuacionSecundaria(0)
            jugadores(i).setCantidadCartasActuales(0)
            jugadores(i).lose = False
            jugadores(i).blackjack = False
            jugadores(i).seguro = False
            punteojugadores(i).ForeColor = Color.White
            punteojugadores(i).Text = ""
        Next
        ficha5_button.Visible = True
        ficha10_button.Visible = True
        ficha50_button.Visible = True
        ficha100_button.Visible = True
        ficha500_button.Visible = True
        ficha1000_button.Visible = True
        px = 764
        py = 25
        jDA = 1
        vueltas = 1
        apos_button.Visible = True
        reiniap_button.Visible = True
        cartasJugadores(0, 1).BringToFront()
        sepagaSeguro = False
        cartaAScrupier = False
        For i = numeroJugadoresIniciales To 1 Step -1
            If jugadores(i).haPerdido Then
                numeroJugadores = i - 1
            Else
                Exit For
            End If
        Next
    End Sub



    'Arrastre
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub
End Class





