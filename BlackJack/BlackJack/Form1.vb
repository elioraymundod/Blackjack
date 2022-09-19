'Este formulario es la pantalla principal



Public Class Form1
    'Imagenes
    Dim jugar_normal As Image = Global.BlackJack.My.Resources.Resources.jugar_normal
    Dim jugar_foc As Image = Global.BlackJack.My.Resources.Resources.jugar_foc
    Dim jugar_press As Image = Global.BlackJack.My.Resources.Resources.jugar_press
    Dim acerca_normal As Image = Global.BlackJack.My.Resources.Resources.acerca_normal
    Dim acerca_foc As Image = Global.BlackJack.My.Resources.Resources.acerca_foc
    Dim acerca_press As Image = Global.BlackJack.My.Resources.Resources.acerca_press
    Dim salir_normal As Image = Global.BlackJack.My.Resources.Resources.salir_normal
    Dim salir_foc As Image = Global.BlackJack.My.Resources.Resources.salir_foc
    Dim salir_press As Image = Global.BlackJack.My.Resources.Resources.salir_press
    Dim cargarp_normal As Image = Global.BlackJack.My.Resources.Resources.cargarp_normal
    Dim cargarp_foc As Image = Global.BlackJack.My.Resources.Resources.cargarp_foc
    Dim cargarp_press As Image = Global.BlackJack.My.Resources.Resources.cargarp_press
    Dim sonido_hab_normal As Image = Global.BlackJack.My.Resources.Resources.sonido_hab_normal
    Dim sonido_hab_foc As Image = Global.BlackJack.My.Resources.Resources.sonido_hab_foc
    Dim sonido_nohab_normal As Image = Global.BlackJack.My.Resources.Resources.sonido_nohab_normal
    Dim sonido_nohab_foc As Image = Global.BlackJack.My.Resources.Resources.sonido_nohab_foc
    Dim musica_hab_normal As Image = Global.BlackJack.My.Resources.Resources.musica_hab_normal
    Dim musica_hab_foc As Image = Global.BlackJack.My.Resources.Resources.musica_hab_foc
    Dim musica_nohab_normal As Image = Global.BlackJack.My.Resources.Resources.musica_nohab_normal
    Dim musica_nohab_foc As Image = Global.BlackJack.My.Resources.Resources.musica_nohab_foc
    Dim hugo As Image = Global.BlackJack.My.Resources.Resources.HugoA
    Dim _1_down As Image = Global.BlackJack.My.Resources.Resources._1_down
    Dim _1_up As Image = Global.BlackJack.My.Resources.Resources._1_up
    Dim _2_down As Image = Global.BlackJack.My.Resources.Resources._2_down
    Dim _2_up As Image = Global.BlackJack.My.Resources.Resources._2_up
    Dim _3_down As Image = Global.BlackJack.My.Resources.Resources._3_down
    Dim _3_up As Image = Global.BlackJack.My.Resources.Resources._3_up
    Dim _4_down As Image = Global.BlackJack.My.Resources.Resources._4_down
    Dim _4_up As Image = Global.BlackJack.My.Resources.Resources._4_up
    Dim _5_down As Image = Global.BlackJack.My.Resources.Resources._5_down
    Dim _5_up As Image = Global.BlackJack.My.Resources.Resources._5_up
    Dim checkbox_con As Image = Global.BlackJack.My.Resources.Resources.checkbox_con
    Dim checkbox_sin As Image = Global.BlackJack.My.Resources.Resources.checkbox_sin
    Dim fup_normal As Image = Global.BlackJack.My.Resources.Resources.fup_normal
    Dim fup_press As Image = Global.BlackJack.My.Resources.Resources.fup_press
    Dim fdown_normal As Image = Global.BlackJack.My.Resources.Resources.fdown_normal
    Dim fdown_press As Image = Global.BlackJack.My.Resources.Resources.fdown_press
    Dim si_normal As Image = Global.BlackJack.My.Resources.Resources.si_normal
    Dim si_foc As Image = Global.BlackJack.My.Resources.Resources.si_foc
    Dim si_press As Image = Global.BlackJack.My.Resources.Resources.si_press
    Dim no_foc As Image = Global.BlackJack.My.Resources.Resources.no_foc
    Dim no_normal As Image = Global.BlackJack.My.Resources.Resources.no_normal
    Dim no_press As Image = Global.BlackJack.My.Resources.Resources.no_press
    'Controles
    Dim panelJuego = New System.Windows.Forms.Panel()
    Dim panelConfiguracion = New System.Windows.Forms.Panel()
    Friend WithEvents si_button As PictureBox = New PictureBox()
    Friend WithEvents no_button As PictureBox = New PictureBox()
    Friend WithEvents jugar_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents iniciarjugar_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents cerrar_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents cerrarconf_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents cerrarjuego_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents about_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents cargarp_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents musica_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents sonido_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents numjugadores1_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents numjugadores2_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents numjugadores3_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents numjugadores4_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents numjugadores5_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents reglaDoblar_checkbox As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents hugoA_img As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents fupApuestaMinima_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents fdownApuestaMinima_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents fupDineroInicial_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents fdownDineroInicial_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents fupMeta_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Friend WithEvents fdownMeta_button As System.Windows.Forms.PictureBox = New System.Windows.Forms.PictureBox()
    Dim panelConfirmacion = New System.Windows.Forms.Panel()
    Dim numeroJugadores_label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
    Dim dineroInicial_label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
    Dim dineroInicialNumero_label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
    Dim apuestaMinima_label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
    Dim apuestaMinimaNumero_label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
    Dim meta_label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
    Dim metaNumero_label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
    Dim reglaDoblar_label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
    Friend WithEvents timer0 As Timer = New Timer()
    Dim mensaje1 As Label = New Label()
    Dim mensaje2 As Label = New Label()
    Dim mensaje3 As Label = New Label()
    Dim mensaje4 As Label = New Label()
    Dim mensaje5 As Label = New Label()
    Dim mensaje6 As Label = New Label()
    'Otras Variables
    Dim _guardarcargar As GuardarCargar = New GuardarCargar()
    Dim musichab As Boolean = True
    Dim sonidohab As Boolean = True
    Dim numeroDeJugadores As Integer = 1
    Dim apuestaMinima As Integer = 200
    Dim dineroInicial As Integer = 5000
    Dim meta As Integer = 20000
    Dim mult As Integer = 1
    Dim reglaDoblar As Boolean = True
    Dim pantallaJuego As Juego
    'Arrastre
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim actdesm As Boolean = True
    'Variables carga de partida
    Dim dineroDeJugadoresColl As Collection = New Collection()
    Dim numeroJugadorest As Integer
    Dim dineroInicialt As Integer
    Dim apuestaMinimat As Integer
    Dim reglaDoublet As Boolean
    Dim metat As Integer
    Dim pop As IO.Stream = Global.BlackJack.My.Resources.Resources.pop
    Dim play1 As System.Media.SoundPlayer = New Media.SoundPlayer

    Private Sub IniciarComponentes()
        play1.Stream = pop
        'Timers
        timer0.Interval = 700
        'Musica
        Me.AxWindowsMediaPlayer1.settings.playCount = 9000
        Me.AxWindowsMediaPlayer1.Ctlcontrols.play()
        'jugar_button
        Me.jugar_button.AccessibleName = "Jugar"
        Me.jugar_button.Location = New System.Drawing.Point(193, 340)
        Me.jugar_button.Name = "jugar_button"
        Me.jugar_button.BackColor = Drawing.Color.Transparent
        Me.jugar_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.jugar_button.Size = New System.Drawing.Size(330, 80)
        Me.jugar_button.BackgroundImage = jugar_normal
        Me.jugar_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.jugar_button)
        'cerrar_button
        Me.cerrar_button.AccessibleName = "Cerrar"
        Me.cerrar_button.Location = New System.Drawing.Point(655, 10)
        Me.cerrar_button.Name = "cerrar_button"
        Me.cerrar_button.BackColor = Drawing.Color.Transparent
        Me.cerrar_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.cerrar_button.Size = New System.Drawing.Size(50, 50)
        Me.cerrar_button.BackgroundImage = salir_normal
        Me.cerrar_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.cerrar_button)
        'mensajes
        mensaje1.AutoSize = True
        mensaje1.Font = New System.Drawing.Font("Garamond", 24.0!)
        mensaje1.ForeColor = System.Drawing.Color.White
        mensaje1.BackColor = Drawing.Color.Transparent
        mensaje1.Location = New System.Drawing.Point(110, 30)
        mensaje1.Name = ("mensaje1")
        mensaje1.Size = New System.Drawing.Size(40, 45)
        mensaje1.Text = "DATOS DE LA PARTIDA"
        Me.panelConfirmacion.Controls.Add(mensaje1)
        mensaje2.AutoSize = True
        mensaje2.Font = New System.Drawing.Font("Garamond", 20.0!)
        mensaje2.ForeColor = System.Drawing.Color.White
        mensaje2.BackColor = Drawing.Color.Transparent
        mensaje2.Location = New System.Drawing.Point(20, 110)
        mensaje2.Name = ("mensaje2")
        mensaje2.Size = New System.Drawing.Size(40, 45)
        mensaje2.Text = "Numero de jugadores: "
        Me.panelConfirmacion.Controls.Add(mensaje2)
        mensaje3.AutoSize = True
        mensaje3.Font = New System.Drawing.Font("Garamond", 20.0!)
        mensaje3.ForeColor = System.Drawing.Color.White
        mensaje3.BackColor = Drawing.Color.Transparent
        mensaje3.Location = New System.Drawing.Point(20, 160)
        mensaje3.Name = ("mensaje3")
        mensaje3.Size = New System.Drawing.Size(40, 45)
        mensaje3.Text = "Dinero Inicial: "
        Me.panelConfirmacion.Controls.Add(mensaje3)
        mensaje4.AutoSize = True
        mensaje4.Font = New System.Drawing.Font("Garamond", 20.0!)
        mensaje4.ForeColor = System.Drawing.Color.White
        mensaje4.BackColor = Drawing.Color.Transparent
        mensaje4.Location = New System.Drawing.Point(20, 210)
        mensaje4.Name = ("mensaje4")
        mensaje4.Size = New System.Drawing.Size(40, 45)
        mensaje4.Text = "Apuesta Minima: "
        Me.panelConfirmacion.Controls.Add(mensaje4)
        mensaje5.AutoSize = True
        mensaje5.Font = New System.Drawing.Font("Garamond", 20.0!)
        mensaje5.ForeColor = System.Drawing.Color.White
        mensaje5.BackColor = Drawing.Color.Transparent
        mensaje5.Location = New System.Drawing.Point(20, 260)
        mensaje5.Name = ("mensaje5")
        mensaje5.Size = New System.Drawing.Size(40, 45)
        mensaje5.Text = "Meta: "
        Me.panelConfirmacion.Controls.Add(mensaje5)
        mensaje6.AutoSize = True
        mensaje6.Font = New System.Drawing.Font("Garamond", 24.0!)
        mensaje6.ForeColor = System.Drawing.Color.White
        mensaje6.BackColor = Drawing.Color.Transparent
        mensaje6.Location = New System.Drawing.Point(110, 330)
        mensaje6.Name = ("mensaje6")
        mensaje6.Size = New System.Drawing.Size(40, 45)
        mensaje6.Text = "¿Desea cargar esta partida?"
        Me.panelConfirmacion.Controls.Add(mensaje6)
        'panelConfirmacion
        Me.panelConfirmacion.BackColor = System.Drawing.Color.Transparent
        Me.panelConfirmacion.BackgroundImage = Global.BlackJack.My.Resources.Resources.mad
        Me.panelConfirmacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelConfirmacion.Name = "panelConfirmacion"
        Me.panelConfirmacion.Location = New System.Drawing.Point(20, 10)
        Me.panelConfirmacion.Size = New System.Drawing.Size(600, 470)
        Me.panelConfirmacion.Visible = False
        Me.panelJuego.Controls.Add(Me.panelConfirmacion)
        Me.panelConfirmacion.BringToFront()
        'si_button
        Me.si_button.AccessibleName = "Si"
        Me.si_button.Location = New System.Drawing.Point(150, 400)
        Me.si_button.Name = "si_button"
        Me.si_button.BackColor = Drawing.Color.Transparent
        Me.si_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.si_button.Size = New System.Drawing.Size(56, 40)
        Me.si_button.BackgroundImage = si_normal
        Me.si_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfirmacion.Controls.Add(Me.si_button)
        'no_button
        Me.no_button.AccessibleName = "No"
        Me.no_button.Location = New System.Drawing.Point(350, 400)
        Me.no_button.Name = "no_button"
        Me.no_button.BackColor = Drawing.Color.Transparent
        Me.no_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.no_button.Size = New System.Drawing.Size(56, 40)
        Me.no_button.BackgroundImage = no_normal
        Me.no_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfirmacion.Controls.Add(Me.no_button)
        'about_button
        Me.about_button.AccessibleName = "Acerca De"
        Me.about_button.Location = New System.Drawing.Point(440, 460)
        Me.about_button.Name = "about_button"
        Me.about_button.BackColor = Drawing.Color.Transparent
        Me.about_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.about_button.Size = New System.Drawing.Size(209, 50)
        Me.about_button.BackgroundImage = acerca_normal
        Me.about_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.about_button)
        'panelJuego
        Me.panelJuego.BackColor = System.Drawing.Color.Transparent
        Me.panelJuego.BackgroundImage = Global.BlackJack.My.Resources.Resources.transp
        Me.panelJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelJuego.Name = "panelJuego"
        Me.panelJuego.Location = New System.Drawing.Point(20, 40)
        Me.panelJuego.Size = New System.Drawing.Size(630, 490)
        Me.panelJuego.Visible = False
        Me.Controls.Add(Me.panelJuego)
        Me.panelJuego.BringToFront()
        'panelConfiguracion
        Me.panelConfiguracion.BackColor = System.Drawing.Color.Transparent
        Me.panelConfiguracion.BackgroundImage = Global.BlackJack.My.Resources.Resources.transp
        Me.panelConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelConfiguracion.Name = "panelConfiguracion"
        Me.panelConfiguracion.Location = New System.Drawing.Point(20, 40)
        Me.panelConfiguracion.Size = New System.Drawing.Size(630, 490)
        Me.panelConfiguracion.Visible = False
        Me.Controls.Add(Me.panelConfiguracion)
        Me.panelConfiguracion.BringToFront()
        'musica_button
        Me.musica_button.AccessibleName = "Musica"
        Me.musica_button.Location = New System.Drawing.Point(20, 450)
        Me.musica_button.Name = "musica_button"
        Me.musica_button.BackColor = Drawing.Color.Transparent
        Me.musica_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.musica_button.Size = New System.Drawing.Size(80, 80)
        Me.musica_button.BackgroundImage = musica_hab_normal
        Me.musica_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.musica_button)
        'sonido_button
        Me.sonido_button.AccessibleName = "Sonido"
        Me.sonido_button.Location = New System.Drawing.Point(120, 450)
        Me.sonido_button.Name = "sonido_button"
        Me.sonido_button.BackColor = Drawing.Color.Transparent
        Me.sonido_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.sonido_button.Size = New System.Drawing.Size(80, 80)
        Me.sonido_button.BackgroundImage = sonido_hab_normal
        Me.sonido_button.Cursor = Windows.Forms.Cursors.Hand
        Me.Controls.Add(Me.sonido_button)
        'cerrarconf_button
        Me.cerrarconf_button.AccessibleName = "CerrarConfiguracion"
        Me.cerrarconf_button.Location = New System.Drawing.Point(570, 10)
        Me.cerrarconf_button.Name = "cerrarconf_button"
        Me.cerrarconf_button.BackColor = Drawing.Color.Transparent
        Me.cerrarconf_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.cerrarconf_button.Size = New System.Drawing.Size(50, 50)
        Me.cerrarconf_button.BackgroundImage = salir_normal
        Me.cerrarconf_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfiguracion.Controls.Add(Me.cerrarconf_button)
        'cerrarjuego_button
        Me.cerrarjuego_button.AccessibleName = "CerrarJuegoConfiguracion"
        Me.cerrarjuego_button.Location = New System.Drawing.Point(570, 10)
        Me.cerrarjuego_button.Name = "cerrarjuego_button"
        Me.cerrarjuego_button.BackColor = Drawing.Color.Transparent
        Me.cerrarjuego_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.cerrarjuego_button.Size = New System.Drawing.Size(50, 50)
        Me.cerrarjuego_button.BackgroundImage = salir_normal
        Me.cerrarjuego_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.cerrarjuego_button)
        'iniciarjugar_button
        Me.iniciarjugar_button.AccessibleName = "Iniciar Juego"
        Me.iniciarjugar_button.Location = New System.Drawing.Point(450, 430)
        Me.iniciarjugar_button.Name = "jugar_button"
        Me.iniciarjugar_button.BackColor = Drawing.Color.Transparent
        Me.iniciarjugar_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.iniciarjugar_button.Size = New System.Drawing.Size(170, 43)
        Me.iniciarjugar_button.BackgroundImage = jugar_normal
        Me.iniciarjugar_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.iniciarjugar_button)
        'cargarp_button
        Me.cargarp_button.AccessibleName = "Cargar Partida"
        Me.cargarp_button.Location = New System.Drawing.Point(20, 430)
        Me.cargarp_button.Name = "cargarp_button"
        Me.cargarp_button.BackColor = Drawing.Color.Transparent
        Me.cargarp_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.cargarp_button.Size = New System.Drawing.Size(202, 43)
        Me.cargarp_button.BackgroundImage = cargarp_normal
        Me.cargarp_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.cargarp_button)
        cargarp_button.Visible = True
        'hugoA_img
        Me.hugoA_img.AccessibleName = "Hugo Alvarado"
        Me.hugoA_img.Location = New System.Drawing.Point(40, 100)
        Me.hugoA_img.Name = "hugoA_img"
        Me.hugoA_img.BackColor = Drawing.Color.Transparent
        Me.hugoA_img.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.hugoA_img.Size = New System.Drawing.Size(550, 200)
        Me.hugoA_img.BackgroundImage = hugo
        Me.hugoA_img.Cursor = Windows.Forms.Cursors.Hand
        Me.panelConfiguracion.Controls.Add(Me.hugoA_img)
        'numjugadores1_button
        Me.numjugadores1_button.AccessibleName = "Numero de jugadores 1"
        Me.numjugadores1_button.Location = New System.Drawing.Point(200 - 180, 50)
        Me.numjugadores1_button.Name = "numjugadores1_button"
        Me.numjugadores1_button.BackColor = Drawing.Color.Transparent
        Me.numjugadores1_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.numjugadores1_button.Size = New System.Drawing.Size(56, 40)
        Me.numjugadores1_button.BackgroundImage = _1_down
        Me.numjugadores1_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.numjugadores1_button)
        'numjugadores2_button
        Me.numjugadores2_button.AccessibleName = "Numero de jugadores 2"
        Me.numjugadores2_button.Location = New System.Drawing.Point(261 - 180, 50)
        Me.numjugadores2_button.Name = "numjugadores2_button"
        Me.numjugadores2_button.BackColor = Drawing.Color.Transparent
        Me.numjugadores2_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.numjugadores2_button.Size = New System.Drawing.Size(56, 40)
        Me.numjugadores2_button.BackgroundImage = _2_up
        Me.numjugadores2_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.numjugadores2_button)
        'numjugadores3_button
        Me.numjugadores3_button.AccessibleName = "Numero de jugadores 3"
        Me.numjugadores3_button.Location = New System.Drawing.Point(322 - 180, 50)
        Me.numjugadores3_button.Name = "numjugadores3_button"
        Me.numjugadores3_button.BackColor = Drawing.Color.Transparent
        Me.numjugadores3_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.numjugadores3_button.Size = New System.Drawing.Size(56, 40)
        Me.numjugadores3_button.BackgroundImage = _3_up
        Me.numjugadores3_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.numjugadores3_button)
        'numjugadores4_button
        Me.numjugadores4_button.AccessibleName = "Numero de jugadores 4"
        Me.numjugadores4_button.Location = New System.Drawing.Point(383 - 180, 50)
        Me.numjugadores4_button.Name = "numjugadores4_button"
        Me.numjugadores4_button.BackColor = Drawing.Color.Transparent
        Me.numjugadores4_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.numjugadores4_button.Size = New System.Drawing.Size(56, 40)
        Me.numjugadores4_button.BackgroundImage = _4_up
        Me.numjugadores4_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.numjugadores4_button)
        'numjugadores5_button
        Me.numjugadores5_button.AccessibleName = "Numero de jugadores 5"
        Me.numjugadores5_button.Location = New System.Drawing.Point(444 - 180, 50)
        Me.numjugadores5_button.Name = "numjugadores5_button"
        Me.numjugadores5_button.BackColor = Drawing.Color.Transparent
        Me.numjugadores5_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.numjugadores5_button.Size = New System.Drawing.Size(56, 40)
        Me.numjugadores5_button.BackgroundImage = _5_up
        Me.numjugadores5_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.numjugadores5_button)
        'numeroJugadores_label
        numeroJugadores_label = New Label()
        numeroJugadores_label.AutoSize = True
        numeroJugadores_label.Font = New System.Drawing.Font("Garamond", 16, FontStyle.Bold)
        numeroJugadores_label.ForeColor = System.Drawing.Color.Gray
        numeroJugadores_label.BackColor = Drawing.Color.Transparent
        numeroJugadores_label.Location = New System.Drawing.Point(20, 20)
        numeroJugadores_label.Name = ("numeroJugadores")
        numeroJugadores_label.Size = New System.Drawing.Size(40, 45)
        numeroJugadores_label.Text = "NUMERO DE JUGADORES"
        panelJuego.Controls.Add(numeroJugadores_label)
        'dineroInicial_label
        dineroInicial_label = New Label()
        dineroInicial_label.AutoSize = True
        dineroInicial_label.Font = New System.Drawing.Font("Garamond", 16, FontStyle.Bold)
        dineroInicial_label.ForeColor = System.Drawing.Color.Gray
        dineroInicial_label.BackColor = Drawing.Color.Transparent
        dineroInicial_label.Location = New System.Drawing.Point(20, 130)
        dineroInicial_label.Name = ("dineroInicial_label")
        dineroInicial_label.Size = New System.Drawing.Size(40, 45)
        dineroInicial_label.Text = "DINERO INICIAL"
        panelJuego.Controls.Add(dineroInicial_label)
        'dineroInicialNumero_label
        dineroInicialNumero_label = New Label()
        dineroInicialNumero_label.AutoSize = True
        dineroInicialNumero_label.Font = New System.Drawing.Font("Garamond", 40, FontStyle.Bold)
        dineroInicialNumero_label.ForeColor = System.Drawing.Color.Gray
        dineroInicialNumero_label.BackColor = Drawing.Color.Transparent
        dineroInicialNumero_label.Location = New System.Drawing.Point(20, 150)
        dineroInicialNumero_label.Name = ("dineroInicialNumero_label")
        dineroInicialNumero_label.Size = New System.Drawing.Size(40, 100)
        dineroInicialNumero_label.Text = "5000"
        panelJuego.Controls.Add(dineroInicialNumero_label)
        'fupDineroInicial_button
        Me.fupDineroInicial_button.AccessibleName = "Flecha Arriba Dinero Inicial"
        Me.fupDineroInicial_button.Location = New System.Drawing.Point(220, 150)
        Me.fupDineroInicial_button.Name = "numjugadores5_button"
        Me.fupDineroInicial_button.BackColor = Drawing.Color.Transparent
        Me.fupDineroInicial_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
        Me.fupDineroInicial_button.Size = New System.Drawing.Size(30, 20)
        Me.fupDineroInicial_button.BackgroundImage = fup_normal
        Me.fupDineroInicial_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.fupDineroInicial_button)
        'fdownDineroInicial_button
        Me.fdownDineroInicial_button.AccessibleName = "Flecha Abajo Dinero Inicial"
        Me.fdownDineroInicial_button.Location = New System.Drawing.Point(220, 175)
        Me.fdownDineroInicial_button.Name = "numjugadores5_button"
        Me.fdownDineroInicial_button.BackColor = Drawing.Color.Transparent
        Me.fdownDineroInicial_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
        Me.fdownDineroInicial_button.Size = New System.Drawing.Size(30, 20)
        Me.fdownDineroInicial_button.BackgroundImage = fdown_normal
        Me.fdownDineroInicial_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.fdownDineroInicial_button)
        'apuestaMinima_label
        apuestaMinima_label = New Label()
        apuestaMinima_label.AutoSize = True
        apuestaMinima_label.Font = New System.Drawing.Font("Garamond", 16, FontStyle.Bold)
        apuestaMinima_label.ForeColor = System.Drawing.Color.Gray
        apuestaMinima_label.BackColor = Drawing.Color.Transparent
        apuestaMinima_label.Location = New System.Drawing.Point(350, 130)
        apuestaMinima_label.Name = ("apuestaMinima_label")
        apuestaMinima_label.Size = New System.Drawing.Size(40, 45)
        apuestaMinima_label.Text = "APUESTA MIN"
        panelJuego.Controls.Add(apuestaMinima_label)
        'apuestaMinimaNumero_label
        apuestaMinimaNumero_label = New Label()
        apuestaMinimaNumero_label.AutoSize = True
        apuestaMinimaNumero_label.Font = New System.Drawing.Font("Garamond", 40, FontStyle.Bold)
        apuestaMinimaNumero_label.ForeColor = System.Drawing.Color.Gray
        apuestaMinimaNumero_label.BackColor = Drawing.Color.Transparent
        apuestaMinimaNumero_label.Location = New System.Drawing.Point(350, 150)
        apuestaMinimaNumero_label.Name = ("apuestaMinimaNumero_label")
        apuestaMinimaNumero_label.Size = New System.Drawing.Size(40, 100)
        apuestaMinimaNumero_label.Text = "200"
        panelJuego.Controls.Add(apuestaMinimaNumero_label)
        'fupApuestaMinima_button
        Me.fupApuestaMinima_button.AccessibleName = "Flecha Arriba Apuesta Minima"
        Me.fupApuestaMinima_button.Location = New System.Drawing.Point(550, 150)
        Me.fupApuestaMinima_button.Name = "numjugadores5_button"
        Me.fupApuestaMinima_button.BackColor = Drawing.Color.Transparent
        Me.fupApuestaMinima_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
        Me.fupApuestaMinima_button.Size = New System.Drawing.Size(30, 20)
        Me.fupApuestaMinima_button.BackgroundImage = fup_normal
        Me.fupApuestaMinima_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.fupApuestaMinima_button)
        'fdownDineroInicial_button
        Me.fdownApuestaMinima_button.AccessibleName = "Flecha Abajo Apuesta Minima"
        Me.fdownApuestaMinima_button.Location = New System.Drawing.Point(550, 175)
        Me.fdownApuestaMinima_button.Name = "numjugadores5_button"
        Me.fdownApuestaMinima_button.BackColor = Drawing.Color.Transparent
        Me.fdownApuestaMinima_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
        Me.fdownApuestaMinima_button.Size = New System.Drawing.Size(30, 20)
        Me.fdownApuestaMinima_button.BackgroundImage = fdown_normal
        Me.fdownApuestaMinima_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.fdownApuestaMinima_button)
        'meta_label
        meta_label = New Label()
        meta_label.AutoSize = True
        meta_label.Font = New System.Drawing.Font("Garamond", 16, FontStyle.Bold)
        meta_label.ForeColor = System.Drawing.Color.Gray
        meta_label.BackColor = Drawing.Color.Transparent
        meta_label.Location = New System.Drawing.Point(230, 240)
        meta_label.Name = ("meta_label")
        meta_label.Size = New System.Drawing.Size(40, 45)
        meta_label.Text = "META"
        panelJuego.Controls.Add(meta_label)
        'metaNumero_label
        metaNumero_label = New Label()
        metaNumero_label.AutoSize = True
        metaNumero_label.Font = New System.Drawing.Font("Garamond", 40, FontStyle.Bold)
        metaNumero_label.ForeColor = System.Drawing.Color.Gray
        metaNumero_label.BackColor = Drawing.Color.Transparent
        metaNumero_label.Location = New System.Drawing.Point(230, 260)
        metaNumero_label.Name = ("metaNumero_label")
        metaNumero_label.Size = New System.Drawing.Size(20, 100)
        metaNumero_label.Text = "20000"
        panelJuego.Controls.Add(metaNumero_label)
        'fupMeta_button
        Me.fupMeta_button.AccessibleName = "Flecha Arriba Apuesta Minima"
        Me.fupMeta_button.Location = New System.Drawing.Point(430, 265)
        Me.fupMeta_button.Name = "numjugadores5_button"
        Me.fupMeta_button.BackColor = Drawing.Color.Transparent
        Me.fupMeta_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
        Me.fupMeta_button.Size = New System.Drawing.Size(30, 20)
        Me.fupMeta_button.BackgroundImage = fup_normal
        Me.fupMeta_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.fupMeta_button)
        'fdownDineroInicial_button
        Me.fdownMeta_button.AccessibleName = "Flecha Abajo Apuesta Minima"
        Me.fdownMeta_button.Location = New System.Drawing.Point(430, 290)
        Me.fdownMeta_button.Name = "numjugadores5_button"
        Me.fdownMeta_button.BackColor = Drawing.Color.Transparent
        Me.fdownMeta_button.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
        Me.fdownMeta_button.Size = New System.Drawing.Size(30, 20)
        Me.fdownMeta_button.BackgroundImage = fdown_normal
        Me.fdownMeta_button.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.fdownMeta_button)
        'reglaDoblar_checkbox
        Me.reglaDoblar_checkbox.AccessibleName = "Regla Doblar"
        Me.reglaDoblar_checkbox.Location = New System.Drawing.Point(40, 350)
        Me.reglaDoblar_checkbox.Name = "reglaDoblar_checkbox"
        Me.reglaDoblar_checkbox.BackColor = Drawing.Color.Transparent
        Me.reglaDoblar_checkbox.BackgroundImageLayout = Windows.Forms.ImageLayout.Zoom
        Me.reglaDoblar_checkbox.Size = New System.Drawing.Size(48, 40)
        Me.reglaDoblar_checkbox.BackgroundImage = checkbox_con
        Me.reglaDoblar_checkbox.Cursor = Windows.Forms.Cursors.Hand
        Me.panelJuego.Controls.Add(Me.reglaDoblar_checkbox)
        'reglaDoblar_label
        reglaDoblar_label = New Label()
        reglaDoblar_label.AutoSize = True
        reglaDoblar_label.Font = New System.Drawing.Font("Garamond", 16, FontStyle.Bold)
        reglaDoblar_label.ForeColor = System.Drawing.Color.Gray
        reglaDoblar_label.BackColor = Drawing.Color.Transparent
        reglaDoblar_label.Location = New System.Drawing.Point(85, 360)
        reglaDoblar_label.Name = ("apuestaMinimaNumero_label")
        reglaDoblar_label.Size = New System.Drawing.Size(40, 100)
        reglaDoblar_label.Text = "Permitir doblar solo con puntuacion de 9, 10 y 11"
        panelJuego.Controls.Add(reglaDoblar_label)
    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarComponentes()
    End Sub


    'Acciones de los botones
    ''si_button
    Private Sub si_button_Click(sender As Object, e As EventArgs) Handles si_button.Click
        Juego.Visible = False
        Juego.setDineroInicial(dineroInicialt)
        Juego.setNumeroJugadores(numeroJugadorest)
        Juego.setApuestaMinima(apuestaMinimat)
        Juego.setMeta(metat)
        Juego.setDoblarRegla(reglaDoublet)
        Juego.Show()
        Juego.reiniciar()
        Juego.setDineroJugadoresCargarPartida(dineroDeJugadoresColl)
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
    ''jugar_button
    Private Sub jugar_button_Click(sender As Object, e As EventArgs) Handles jugar_button.Click
        panelJuego.Show()
        panelConfirmacion.Visible = False
        If sonidohab Then
            play1.Play()
        End If
    End Sub
    Private Sub jugar_button_MouseDown(sender As Object, e As EventArgs) Handles jugar_button.MouseDown
        jugar_button.BackgroundImage = jugar_press
    End Sub
    Private Sub jugar_button_MouseLeave(sender As Object, e As EventArgs) Handles jugar_button.MouseLeave
        jugar_button.BackgroundImage = jugar_normal
    End Sub
    Private Sub jugar_button_MouseMove(sender As Object, e As EventArgs) Handles jugar_button.MouseMove
        jugar_button.BackgroundImage = jugar_foc
    End Sub
    ''cerrar_button
    Private Sub cerrar_button_Click(sender As Object, e As EventArgs) Handles cerrar_button.Click
        End
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

    ''cerrarjuego_button
    Private Sub cerrarjuego_button_Click(sender As Object, e As EventArgs) Handles cerrarjuego_button.Click
        panelJuego.Hide()
        If sonidohab Then
            play1.Play()
        End If
    End Sub
    Private Sub cerrarjuego_button_MouseDown(sender As Object, e As EventArgs) Handles cerrarjuego_button.MouseDown
        cerrarjuego_button.BackgroundImage = salir_press
    End Sub
    Private Sub cerrarjuego_button_MouseLeave(sender As Object, e As EventArgs) Handles cerrarjuego_button.MouseLeave
        cerrarjuego_button.BackgroundImage = salir_normal
    End Sub
    Private Sub cerrarjuego_button_MouseMove(sender As Object, e As EventArgs) Handles cerrarjuego_button.MouseMove
        cerrarjuego_button.BackgroundImage = salir_foc
    End Sub
    ''cerrarconf_button
    Private Sub cerrarconf_button_Click(sender As Object, e As EventArgs) Handles cerrarconf_button.Click
        panelConfiguracion.Visible = False
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
    ''about_button
    Private Sub about_button_Click(sender As Object, e As EventArgs) Handles about_button.Click
        panelConfiguracion.Visible = True
        If sonidohab Then
            play1.Play()
        End If
    End Sub
    Private Sub about_button_MouseDown(sender As Object, e As EventArgs) Handles about_button.MouseDown
        about_button.BackgroundImage = acerca_press
    End Sub
    Private Sub about_button_MouseLeave(sender As Object, e As EventArgs) Handles about_button.MouseLeave
        about_button.BackgroundImage = acerca_normal
    End Sub
    Private Sub about_button_MouseMove(sender As Object, e As EventArgs) Handles about_button.MouseMove
        about_button.BackgroundImage = acerca_foc
    End Sub
    ''cargarp_button
    Private Sub cargarp_button_Click(sender As Object, e As EventArgs) Handles cargarp_button.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName() = Nothing Or OpenFileDialog1.FileName() = "" Then
        Else
            _guardarcargar.leerArchivo(OpenFileDialog1.FileName())
            metat = _guardarcargar.getMeta()
            numeroJugadorest = _guardarcargar.getNumeroJugadores()
            dineroInicialt = _guardarcargar.getDineroInicial()
            apuestaMinimat = _guardarcargar.getApuestaMinima()
            reglaDoublet = _guardarcargar.getReglaDouble()
            dineroDeJugadoresColl = _guardarcargar.getDineroJugadores()
            mensaje2.Text = "Numero de jugadores: " & numeroJugadorest
            mensaje3.Text = "Dinero Inicial: " & dineroInicialt
            mensaje4.Text = "Apuesta Minima: " & apuestaMinimat
            mensaje5.Text = "Meta: " & metat
            panelConfirmacion.Visible = True
            OpenFileDialog1.FileName = Nothing
        End If
    End Sub
    Private Sub cargarp_buttonn_MouseDown(sender As Object, e As EventArgs) Handles cargarp_button.MouseDown
        cargarp_button.BackgroundImage = cargarp_press
    End Sub
    Private Sub cargarp_button_MouseLeave(sender As Object, e As EventArgs) Handles cargarp_button.MouseLeave
        cargarp_button.BackgroundImage = cargarp_normal
    End Sub
    Private Sub cargarp_button_MouseMove(sender As Object, e As EventArgs) Handles cargarp_button.MouseMove
        cargarp_button.BackgroundImage = cargarp_foc
    End Sub
    ''iniciarjugar_button
    Private Sub iniciarjugar_button_Click(sender As Object, e As EventArgs) Handles iniciarjugar_button.Click
        Juego.Visible = False
        Juego.setDineroInicial(dineroInicial)
        Juego.setNumeroJugadores(numeroDeJugadores)
        Juego.setApuestaMinima(apuestaMinima)
        Juego.setMeta(meta)
        Juego.setDoblarRegla(reglaDoblar)
        Juego.Show()
        Juego.reiniciar()
        Me.Hide()
    End Sub
    Private Sub iniciarjugar_button_MouseDown(sender As Object, e As EventArgs) Handles iniciarjugar_button.MouseDown
        iniciarjugar_button.BackgroundImage = jugar_press
    End Sub
    Private Sub iniciarjugar_button_MouseLeave(sender As Object, e As EventArgs) Handles iniciarjugar_button.MouseLeave
        iniciarjugar_button.BackgroundImage = jugar_normal
    End Sub
    Private Sub iniciarjugar_button_MouseMove(sender As Object, e As EventArgs) Handles iniciarjugar_button.MouseMove
        iniciarjugar_button.BackgroundImage = jugar_foc
    End Sub
    ''musica_button
    Private Sub musica_button_Click(sender As Object, e As EventArgs) Handles musica_button.Click
        If musichab Then
            musica_button.BackgroundImage = musica_nohab_foc
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            musichab = False
            Juego.setMusicaHabilitado(False)
        Else
            musica_button.BackgroundImage = musica_hab_foc
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            musichab = True
            Juego.setMusicaHabilitado(True)
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
            Juego.setSonidoHabilitado(False)
        Else
            sonido_button.BackgroundImage = sonido_hab_foc
            sonidohab = True
            Juego.setSonidoHabilitado(True)
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
    'Eleccion de numero de jugadores
    Private Sub numjugadores1_button_Click(sender As Object, e As EventArgs) Handles numjugadores1_button.Click
        numjugadores1_button.BackgroundImage = _1_down
        numjugadores2_button.BackgroundImage = _2_up
        numjugadores3_button.BackgroundImage = _3_up
        numjugadores4_button.BackgroundImage = _4_up
        numjugadores5_button.BackgroundImage = _5_up
        numeroDeJugadores = 1
    End Sub
    Private Sub numjugadores2_button_Click(sender As Object, e As EventArgs) Handles numjugadores2_button.Click
        numjugadores1_button.BackgroundImage = _1_up
        numjugadores2_button.BackgroundImage = _2_down
        numjugadores3_button.BackgroundImage = _3_up
        numjugadores4_button.BackgroundImage = _4_up
        numjugadores5_button.BackgroundImage = _5_up
        numeroDeJugadores = 2
    End Sub
    Private Sub numjugadores3_button_Click(sender As Object, e As EventArgs) Handles numjugadores3_button.Click
        numjugadores1_button.BackgroundImage = _1_up
        numjugadores2_button.BackgroundImage = _2_up
        numjugadores3_button.BackgroundImage = _3_down
        numjugadores4_button.BackgroundImage = _4_up
        numjugadores5_button.BackgroundImage = _5_up
        numeroDeJugadores = 3
    End Sub
    Private Sub numjugadores4_button_Click(sender As Object, e As EventArgs) Handles numjugadores4_button.Click
        numjugadores1_button.BackgroundImage = _1_up
        numjugadores2_button.BackgroundImage = _2_up
        numjugadores3_button.BackgroundImage = _3_up
        numjugadores4_button.BackgroundImage = _4_down
        numjugadores5_button.BackgroundImage = _5_up
        numeroDeJugadores = 4
    End Sub
    Private Sub numjugadores5_button_Click(sender As Object, e As EventArgs) Handles numjugadores5_button.Click
        numjugadores1_button.BackgroundImage = _1_up
        numjugadores2_button.BackgroundImage = _2_up
        numjugadores3_button.BackgroundImage = _3_up
        numjugadores4_button.BackgroundImage = _4_up
        numjugadores5_button.BackgroundImage = _5_down
        numeroDeJugadores = 5
    End Sub
    'fupApuestaMinima_button
    Private Sub fupApuestaMinima_button_Click(sender As Object, e As EventArgs) Handles fupApuestaMinima_button.Click
        If apuestaMinima + (dineroInicial / 50) <= dineroInicial Then
            apuestaMinima = apuestaMinima + (dineroInicial / 50)
            apuestaMinimaNumero_label.Text = apuestaMinima
        End If
    End Sub
    Private Sub fupApuestaMinima_button_MouseDown(sender As Object, e As EventArgs) Handles fupApuestaMinima_button.MouseDown
        fupApuestaMinima_button.BackgroundImage = fup_press
    End Sub
    Private Sub fupApuestaMinima_button_MouseUp(sender As Object, e As EventArgs) Handles fupApuestaMinima_button.MouseUp
        fupApuestaMinima_button.BackgroundImage = fup_normal
    End Sub
    'fdownApuestaMinima_button
    Private Sub fdownApuestaMinima_button_Click(sender As Object, e As EventArgs) Handles fdownApuestaMinima_button.Click
        If apuestaMinima - (dineroInicial / 50) >= 0 Then
            apuestaMinima = apuestaMinima - (dineroInicial / 50)
            apuestaMinimaNumero_label.Text = apuestaMinima
        End If
    End Sub
    Private Sub fdownApuestaMinima_button_MouseDown(sender As Object, e As EventArgs) Handles fdownApuestaMinima_button.MouseDown
        fdownApuestaMinima_button.BackgroundImage = fdown_press
    End Sub
    Private Sub fdownApuestaMinima_button_MouseUp(sender As Object, e As EventArgs) Handles fdownApuestaMinima_button.MouseUp
        fdownApuestaMinima_button.BackgroundImage = fdown_normal
    End Sub
    'fupDineroInicial_button
    Private Sub fupDineroInicial_button_Click(sender As Object, e As EventArgs) Handles fupDineroInicial_button.Click
        If dineroInicial + (1000 * mult) <= 1000000 Then
            dineroInicial = dineroInicial + (1000 * mult)
            dineroInicialNumero_label.Text = dineroInicial
            mult = mult * 10
            meta = dineroInicial * 2
            metaNumero_label.Text = dineroInicial * 2
            apuestaMinima = 0
            apuestaMinimaNumero_label.Text = 0
            timer0.Start()
        End If
    End Sub
    Private Sub fupDineroInicial_button_MouseDown(sender As Object, e As EventArgs) Handles fupDineroInicial_button.MouseDown
        fupDineroInicial_button.BackgroundImage = fup_press
    End Sub
    Private Sub fupDineroInicial_button_MouseUp(sender As Object, e As EventArgs) Handles fupDineroInicial_button.MouseUp
        fupDineroInicial_button.BackgroundImage = fup_normal
    End Sub
    'fdownDineroInicial_button
    Private Sub fdownDineroInicial_button_Click(sender As Object, e As EventArgs) Handles fdownDineroInicial_button.Click
        If dineroInicial - (1000 * mult) > 0 Then
            dineroInicial = dineroInicial - (1000 * mult)
            dineroInicialNumero_label.Text = dineroInicial
            mult = mult * 10
            meta = dineroInicial * 2
            metaNumero_label.Text = dineroInicial * 2
            apuestaMinima = 0
            apuestaMinimaNumero_label.Text = 0
            timer0.Start()
        End If
    End Sub
    Private Sub fdownDineroInicial_button_MouseDown(sender As Object, e As EventArgs) Handles fdownDineroInicial_button.MouseDown
        fdownDineroInicial_button.BackgroundImage = fdown_press
    End Sub
    Private Sub fdownDineroInicial_button_MouseUp(sender As Object, e As EventArgs) Handles fdownDineroInicial_button.MouseUp
        fdownDineroInicial_button.BackgroundImage = fdown_normal
    End Sub
    'fupMeta_button
    Private Sub fupMeta_button_Click(sender As Object, e As EventArgs) Handles fupMeta_button.Click
        If meta + (dineroInicial) <= 10000000 Then
            meta = meta + dineroInicial
            metaNumero_label.Text = meta
        End If
    End Sub
    Private Sub fupMeta_button_MouseDown(sender As Object, e As EventArgs) Handles fupMeta_button.MouseDown
        fupMeta_button.BackgroundImage = fup_press
    End Sub
    Private Sub fupMeta_button_MouseUp(sender As Object, e As EventArgs) Handles fupMeta_button.MouseUp
        fupMeta_button.BackgroundImage = fup_normal
    End Sub
    'fdownMeta_button
    Private Sub fdownMeta_button_Click(sender As Object, e As EventArgs) Handles fdownMeta_button.Click
        If (meta - dineroInicial) > dineroInicial Then
            meta = meta - dineroInicial
            metaNumero_label.Text = meta
        End If
    End Sub
    Private Sub fdownMeta_button_MouseDown(sender As Object, e As EventArgs) Handles fdownMeta_button.MouseDown
        fdownMeta_button.BackgroundImage = fdown_press
    End Sub
    Private Sub fdownMeta_button_MouseUp(sender As Object, e As EventArgs) Handles fdownMeta_button.MouseUp
        fdownMeta_button.BackgroundImage = fdown_normal
    End Sub
    'CheckBox Regla Doblar
    Private Sub reglaDoblar_checkbox_Click(sender As Object, e As EventArgs) Handles reglaDoblar_checkbox.Click
        If reglaDoblar Then
            reglaDoblar_checkbox.BackgroundImage = checkbox_sin
            reglaDoblar = False
        Else
            reglaDoblar_checkbox.BackgroundImage = checkbox_con
            reglaDoblar = True
        End If
    End Sub


    Private Sub timer0_Tick(sender As Object, e As EventArgs) Handles timer0.Tick
        timer0.Stop()
        mult = 1
    End Sub

    Public Sub mostrarPanelJuego()
        panelJuego.Show()
    End Sub
    Public Sub ocultarPanelJuego()
        panelJuego.Hide()
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
