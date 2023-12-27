package Epe;

//Importamos las librerías necesarias para el funcionamiento del programa
import java.awt.BorderLayout;
import java.awt.Font;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JComboBox;
import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.SQLException;
import java.text.DecimalFormat;
import javax.swing.DefaultListModel;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.JList;
import javax.swing.JTextArea;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;

//Usamos extends para importar la clase  javax.swing  y incluimos implements ActionListener para darle funcionalidad a los botones.
public final class windows extends JFrame implements ActionListener {

    //Creamos variables globales y  objetos que usaremos en el programa. 
    String patron = "#,###";
    JList lista = new JList();
    DefaultListModel modelo = new DefaultListModel();
    DefaultListModel modeloPrecio = new DefaultListModel();
    DecimalFormat formato = new DecimalFormat(patron);
    JTextArea tArea_coment = new JTextArea();
    JLabel label_Total = new JLabel();
    Date date = new Date();
    JButton reinicio = new JButton("Nueva comanda");
    JComboBox coBox_Empleados = new JComboBox();
    JPanel fondo = new JPanel();
    JPanel panel_Superior = new JPanel();
    JPanel panel_Listascomanda = new JPanel();
    JPanel panel_Botones = new JPanel();
    JLabel label_Superior_nombre_De_empleados = new JLabel();
    JLabel label_Superior_comentario = new JLabel();
    JLabel label_Date = new JLabel();
    JLabel lavel_Logo = new JLabel();
    public int preciotacos = 12999;
    public int precioBrochetas = 9990;
    public int precioLomo = 11990;
    public int precioCarne = 14000;
    public int precioEnsalada = 5600;
    public int precioHamburguesa = 7000;
    public int precioVino = 3000;
    public int precioCerveza = 2500;
    public int precioCoca = 1200;
    public int precioFanta = 1200;
    public int total = 0;

    //creamos la clase principal windows
    public windows() throws SQLException {

        //Establecer titulo de la ventana.
        setTitle("Programa de comandas");

        //Establecer el tamaño de la ventana.
        setSize(1500, 700);
        setResizable(false);

        //Establecer posicion al centro de la pantalla.
        setLocationRelativeTo(null);

        //Cerrar el programa al precionar cerrar.
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        //Instancioamos los metodos  que haran funcionar el programa.
        component();
        reiniciar();
        botones();

         conexion con = new conexion();
       
    }

    private void component() {

        /////////////////////////////////////// Configuración Jpanel de Fondo  /////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        this.getContentPane().add(fondo);
        fondo.setLayout(new BorderLayout());//Establcemos el border layaut para  dar formato al panel principal
        fondo.add(panel_Superior, BorderLayout.NORTH);//Colocamos el panel superior en el panel principal, con direcion hacia el norte
        fondo.add(panel_Listascomanda, BorderLayout.EAST);//Colocamos el panel_Listascomanda en el panel principal, con direcion hacia el norte
        fondo.add(panel_Botones, BorderLayout.CENTER);//Colocamos el panel_Botones en el panel principal, con direcion hacia el norte
        ///////////////////////////////  Configuración Panel contenedor de los botones  ////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        panel_Botones.setLayout(new GridLayout(2, 5));
        panel_Botones.setBackground(Color.blue);
        ///////////////////////////////////////  Configuración de panel superior  ///////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        panel_Superior.setPreferredSize(new java.awt.Dimension(1000, 300));
        panel_Superior.setBackground(Color.red);
        panel_Superior.setOpaque(true);
        panel_Superior.setBackground(Color.decode("#032D30"));
        panel_Superior.setLayout(null);//DEsacivamos el layaut del el panel superior para organisar manualmente los elmentos de este
        ///////////////////////////////////////  Label texto sobre comboBox  ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       
        label_Superior_nombre_De_empleados.setLayout(null);
        label_Superior_nombre_De_empleados.setBounds(20, 20, 300, 30);
        label_Superior_nombre_De_empleados.setBackground(Color.decode("#032D30"));
        label_Superior_nombre_De_empleados.setForeground(Color.WHITE);
        label_Superior_nombre_De_empleados.setFont(new Font("JetBrains Mono", Font.BOLD, 20));
        label_Superior_nombre_De_empleados.setText("Seleccione al empleado");
        label_Superior_nombre_De_empleados.setOpaque(true);
        panel_Superior.add(label_Superior_nombre_De_empleados);
        //////////////////////////////////////  Label texto sobre texArea  /////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        label_Superior_comentario.setLayout(null);
        label_Superior_comentario.setBounds(20, 100, 300, 30);
        label_Superior_comentario.setBackground(Color.decode("#032D30"));
        label_Superior_comentario.setForeground(Color.WHITE);
        label_Superior_comentario.setFont(new Font("JetBrains Mono", Font.BOLD, 20));
        label_Superior_comentario.setText("Ingrese comentario");
        label_Superior_comentario.setOpaque(true);
        panel_Superior.add(label_Superior_comentario);
        //////////////////////////////////////  Label texto precio total  /////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        label_Total.setLayout(null);
        label_Total.setBounds(1100, 250, 400, 60);
        label_Total.setFont(new Font("JetBrains Mono", Font.BOLD, 20));
        label_Total.setText("Total: " + total);
        label_Total.setForeground(Color.WHITE);
        panel_Superior.add(label_Total);
        ////////////////////////////////////////  Label texto Fecha y hora  ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////      
        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy  ");
        label_Date.setBackground(Color.decode("#032D30"));
        label_Date.setForeground(Color.WHITE);
        label_Date.setFont(new Font("JetBrains Mono", Font.BOLD, 20));
        label_Date.setText(sdf.format(date));
        label_Date.setOpaque(true);
        label_Date.setBounds(1360, 10, 400, 40);
        panel_Superior.add(label_Date);
        ///////////////////////////////////////  Label Configuracion de logo  ///////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_logo = new ImageIcon(getClass().getResource("/Imagenes/Logo.png"));
        lavel_Logo.setIcon(new ImageIcon(image_logo.getImage().getScaledInstance(200, 200, 1)));
        lavel_Logo.setOpaque(false);
        lavel_Logo.setBounds(650, 10, 300, 300);
        panel_Superior.add(lavel_Logo);
        ///////////////////////////   Configuración de Jpanel para listas de comanda  //////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        panel_Listascomanda.setLayout(new BorderLayout());
        panel_Listascomanda.setPreferredSize(new java.awt.Dimension(400, 400));
        ///////////////////////////////////   Configuración  listas de productos  //////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        panel_Listascomanda.add(lista, BorderLayout.NORTH);
        lista.setBounds(0, 0, 400, 300);
        lista.setFont(new Font("JetBrains Mono", Font.BOLD, 20));
        panel_Listascomanda.add(new JScrollPane(lista));
       
        ///////////////////////////////////////   Configuración comboBox  //////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        coBox_Empleados.setBounds(10, 60, 350, 30);
        coBox_Empleados.addItem("Empleado número  uno");
        coBox_Empleados.addItem("Empleado número  dos");
        coBox_Empleados.addItem("Empleado número  tres");
        coBox_Empleados.addItem("Empleado número  cuatro");
        coBox_Empleados.addItem("Empleado número  cinco");
        coBox_Empleados.addItem("Empleado número  seis");
        coBox_Empleados.setFont(new Font("JetBrains Mono", Font.BOLD, 16));
        panel_Superior.add(coBox_Empleados, BorderLayout.EAST);
        ///////////////////////////////////////   Configuración TextArea  //////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        tArea_coment.setBounds(10, 130, 350, 140);
        panel_Superior.add(tArea_coment, BorderLayout.EAST);
        tArea_coment.setFont(new Font("JetBrains Mono", Font.BOLD, 16));
        tArea_coment.setLineWrap(true);
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   
    /**
     *
     */
    private void botones() {

        //////////////////////////////////////////////  Boton1  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //establece la imagen 
        ImageIcon image_taco = new ImageIcon(getClass().getResource("/Imagenes/taco.png"));
        //crea un nuevo label que sera colocado en
        JLabel lavel_boton1 = new JLabel();
        lavel_boton1.setLayout(null);
        lavel_boton1.setBounds(30, 10, 100, 100);
        lavel_boton1.setIcon(new ImageIcon(image_taco.getImage().getScaledInstance(100, 100, 1)));
        JButton boton1 = new JButton();
        boton1.setBounds(10, 20, 170, 170);
        panel_Botones.add(boton1);
        boton1.add(lavel_boton1);
        boton1.setLayout(null);
        JLabel textoboton1 = new JLabel("Tacos al pastor");
        
        JLabel precioboton1 = new JLabel("precio: " + formato.format(preciotacos));
        textoboton1.setBounds(15, 110, 150, 30);
        precioboton1.setBounds(15, 130, 150, 30);
        textoboton1.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton1.add(textoboton1);
        boton1.add(precioboton1);
        precioboton1.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton2  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_Brochetas = new ImageIcon(getClass().getResource("/Imagenes/Brochetas.png"));
        JLabel lavel_boton2 = new JLabel();
        lavel_boton2.setLayout(null);
        lavel_boton2.setBounds(40, 10, 100, 100);
        lavel_boton2.setIcon(new ImageIcon(image_Brochetas.getImage().getScaledInstance(80, 80, 1)));
        JButton boton2 = new JButton();
        boton2.setBounds(200, 20, 170, 170);
        panel_Botones.add(boton2);
        boton2.add(lavel_boton2);
        boton2.setLayout(null);
        JLabel textoboton2 = new JLabel("Brochetas de res");
        JLabel precioboton2 = new JLabel("precio: " + formato.format(precioBrochetas));
        textoboton2.setBounds(15, 110, 150, 30);
        precioboton2.setBounds(15, 130, 150, 30);
        textoboton2.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton2.add(textoboton2);
        boton2.add(precioboton2);
        precioboton2.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton3  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_Lomo = new ImageIcon(getClass().getResource("/Imagenes/Lomo.png"));
        JLabel lavel_boton3 = new JLabel();
        lavel_boton3.setLayout(null);
        lavel_boton3.setBounds(30, 10, 100, 100);
        lavel_boton3.setIcon(new ImageIcon(image_Lomo.getImage().getScaledInstance(100, 100, 1)));
        JButton boton3 = new JButton();
        boton3.setBounds(390, 20, 170, 170);
        panel_Botones.add(boton3);
        boton3.add(lavel_boton3);
        boton3.setLayout(null);
        JLabel textoboton3 = new JLabel("Lomo salteado");
        JLabel precioboton3 = new JLabel("precio: " + formato.format(precioLomo));
        textoboton3.setBounds(15, 110, 150, 30);
        precioboton3.setBounds(15, 130, 150, 30);
        textoboton3.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton3.add(textoboton3);
        boton3.add(precioboton3);
        precioboton3.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton4  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_carne = new ImageIcon(getClass().getResource("/Imagenes/carne.png"));
        JLabel lavel_boton4 = new JLabel();
        lavel_boton4.setLayout(null);
        lavel_boton4.setBounds(30, 10, 100, 100);
        lavel_boton4.setIcon(new ImageIcon(image_carne.getImage().getScaledInstance(100, 100, 1)));
        JButton boton4 = new JButton();
        boton4.setBounds(580, 20, 170, 170);
        panel_Botones.add(boton4);
        boton4.add(lavel_boton4);
        boton4.setLayout(null);
        JLabel textoboton4 = new JLabel("Carne asada");
        JLabel precioboton4 = new JLabel("precio: " + formato.format(precioCarne));
        textoboton4.setBounds(15, 110, 150, 30);
        precioboton4.setBounds(15, 130, 150, 30);
        textoboton4.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton4.add(textoboton4);
        boton4.add(precioboton4);
        precioboton4.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton5  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_ensalada = new ImageIcon(getClass().getResource("/Imagenes/ensalada.png"));
        JLabel lavel_boton5 = new JLabel();
        lavel_boton5.setLayout(null);
        lavel_boton5.setBounds(30, 10, 100, 100);
        lavel_boton5.setIcon(new ImageIcon(image_ensalada.getImage().getScaledInstance(100, 100, 1)));
        JButton boton5 = new JButton();
        boton5.setBounds(770, 20, 170, 170);
        panel_Botones.add(boton5);
        boton5.add(lavel_boton5);
        boton5.setLayout(null);
        JLabel textoboton5 = new JLabel("Ensalada cessar");
        JLabel precioboton5 = new JLabel("precio: " + formato.format(precioEnsalada));
        textoboton5.setBounds(15, 110, 150, 30);
        precioboton5.setBounds(15, 130, 150, 30);
        textoboton5.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton5.add(textoboton5);
        boton5.add(precioboton5);
        precioboton5.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton6  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //establece la imagen 
        ImageIcon image_hamburguesa = new ImageIcon(getClass().getResource("/Imagenes/hamburguesa.png"));
        //crea un nuevo label que sera colocado en
        JLabel lavel_boton6 = new JLabel();
        lavel_boton6.setLayout(null);
        lavel_boton6.setBounds(30, 10, 100, 100);
        lavel_boton6.setIcon(new ImageIcon(image_hamburguesa.getImage().getScaledInstance(100, 100, 1)));
        JButton boton6 = new JButton();
        boton6.setBounds(10, 220, 170, 170);
        panel_Botones.add(boton6);
        boton6.add(lavel_boton6);
        boton6.setLayout(null);
        JLabel textoboton6 = new JLabel("Hamburguesa ");
        JLabel precioboton6 = new JLabel("precio: " + formato.format(precioHamburguesa));
        textoboton6.setBounds(15, 110, 150, 30);
        precioboton6.setBounds(15, 130, 150, 30);
        textoboton6.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton6.add(textoboton6);
        boton6.add(precioboton6);
        precioboton6.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton7  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_Vino = new ImageIcon(getClass().getResource("/Imagenes/vino.png"));
        JLabel lavel_boton7 = new JLabel();
        lavel_boton7.setLayout(null);
        lavel_boton7.setBounds(30, 10, 100, 100);
        lavel_boton7.setIcon(new ImageIcon(image_Vino.getImage().getScaledInstance(100, 100, 1)));
        JButton boton7 = new JButton();
        boton7.setBounds(200, 220, 170, 170);
        panel_Botones.add(boton7);
        boton7.add(lavel_boton7);
        boton7.setLayout(null);
        JLabel textoboton7 = new JLabel("Vaso de vino");
        JLabel precioboton7 = new JLabel("precio: " + formato.format(precioVino));
        textoboton7.setBounds(15, 110, 150, 30);
        precioboton7.setBounds(15, 130, 150, 30);
        textoboton7.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton7.add(textoboton7);
        boton7.add(precioboton7);
        precioboton7.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton8  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_Cervesa = new ImageIcon(getClass().getResource("/Imagenes/cerveza.png"));
        JLabel lavel_boton8 = new JLabel();
        lavel_boton8.setLayout(null);
        lavel_boton8.setBounds(30, 10, 100, 100);
        lavel_boton8.setIcon(new ImageIcon(image_Cervesa.getImage().getScaledInstance(100, 100, 1)));
        JButton boton8 = new JButton();
        boton8.setBounds(390, 220, 170, 170);
        panel_Botones.add(boton8);
        boton8.add(lavel_boton8);
        boton8.setLayout(null);
        JLabel textoboton8 = new JLabel("Vaso de cerveza");
        JLabel precioboton8 = new JLabel("precio: " + formato.format(precioCerveza));
        textoboton8.setBounds(15, 110, 150, 30);
        precioboton8.setBounds(15, 130, 150, 30);
        textoboton8.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton8.add(textoboton8);
        boton8.add(precioboton8);
        precioboton8.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton9  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_carne9 = new ImageIcon(getClass().getResource("/Imagenes/coca.png"));
        JLabel lavel_boton9 = new JLabel();
        lavel_boton9.setLayout(null);
        lavel_boton9.setBounds(30, 10, 100, 100);
        lavel_boton9.setIcon(new ImageIcon(image_carne9.getImage().getScaledInstance(100, 100, 1)));
        JButton boton9 = new JButton();
        boton9.setBounds(580, 220, 170, 170);
        panel_Botones.add(boton9);
        boton9.add(lavel_boton9);
        boton9.setLayout(null);
        JLabel textoboton9 = new JLabel("Vaso de coca-cola");
        JLabel precioboton9 = new JLabel("precio: " + formato.format(precioCoca));
        textoboton9.setBounds(15, 110, 150, 30);
        precioboton9.setBounds(15, 130, 150, 30);
        textoboton9.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton9.add(textoboton9);
        boton9.add(precioboton9);
        precioboton9.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        //////////////////////////////////////////////  Boton10  ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ImageIcon image_ensalada10 = new ImageIcon(getClass().getResource("/Imagenes/fanta.png"));
        JLabel lavel_boton10 = new JLabel();
        lavel_boton10.setLayout(null);
        lavel_boton10.setBounds(30, 10, 100, 100);
        lavel_boton10.setIcon(new ImageIcon(image_ensalada10.getImage().getScaledInstance(100, 100, 1)));
        JButton boton10 = new JButton();
        boton10.setBounds(770, 220, 170, 170);
        panel_Botones.add(boton10);
        boton10.add(lavel_boton10);
        boton10.setLayout(null);
        JLabel textoboton10 = new JLabel("Vaso de fanta");
        JLabel precioboton10 = new JLabel("precio: " + formato.format(precioFanta));
        textoboton10.setBounds(15, 110, 150, 30);
        precioboton10.setBounds(15, 130, 150, 30);
        textoboton10.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));
        boton10.add(textoboton10);
        boton10.add(precioboton10);
        precioboton10.setFont(new Font("JetBrains Mono", Font.ITALIC, 13));

        ////////////////////////////////   addActionListener y setActionCommand   //////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //establecemos addActionListener y setActionCommand para detectar y manejar eventos de acci?n en los botones
        boton1.addActionListener((ActionListener) this);
        boton2.addActionListener((ActionListener) this);
        boton3.addActionListener((ActionListener) this);
        boton4.addActionListener((ActionListener) this);
        boton5.addActionListener((ActionListener) this);
        boton6.addActionListener((ActionListener) this);
        boton7.addActionListener((ActionListener) this);
        boton8.addActionListener((ActionListener) this);
        boton9.addActionListener((ActionListener) this);
        boton10.addActionListener((ActionListener) this);
        reinicio.addActionListener((ActionListener) this);

        boton1.setActionCommand("boton1");
        boton2.setActionCommand("boton2");
        boton3.setActionCommand("boton3");
        boton4.setActionCommand("boton4");
        boton5.setActionCommand("boton5");
        boton6.setActionCommand("boton6");
        boton7.setActionCommand("boton7");
        boton8.setActionCommand("boton8");
        boton9.setActionCommand("boton9");
        boton10.setActionCommand("boton10");
        reinicio.setActionCommand("reinicio");

    }

    /*Crearemos las funciones para  cuando cliqueemos los botones implementando un switch por cada botón con sus respectivas funciones
    además estableceremos la función para un botón que nos permita resetear la comanda */
    @Override
    public void actionPerformed(ActionEvent e) {

        switch (e.getActionCommand()) {
            case "boton1" -> {
                modelo.addElement("Tacos al pastor = " + formato.format(preciotacos));
                lista.setModel(modelo);
                total = total + preciotacos;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton1");

            }
            case "boton2" -> {
                modelo.addElement("Brochetas de res = " + formato.format(precioBrochetas));
                lista.setModel(modelo);
                total = total + precioBrochetas;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 2");
            }
            case "boton3" -> {
                modelo.addElement("Lomo salteado = " + formato.format(precioLomo));
                lista.setModel(modelo);
                total = total + precioLomo;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 3");
            }
            case "boton4" -> {
                modelo.addElement("Carne asada = " + formato.format(precioCarne));
                lista.setModel(modelo);
                total = total + precioCarne;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 4");
            }
            case "boton5" -> {
                modelo.addElement("Ensalada cessar = " + formato.format(precioEnsalada));
                lista.setModel(modelo);
                total = total + precioEnsalada;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 5");
            }
            case "boton6" -> {
                modelo.addElement("hamburguesa = " + formato.format(precioHamburguesa));
                lista.setModel(modelo);
                total = total + precioHamburguesa;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 6");
            }
            case "boton7" -> {
                modelo.addElement("Vaso de vino = " + formato.format(precioVino));
                lista.setModel(modelo);
                total = total + precioVino;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 7");
            }
            case "boton8" -> {
                modelo.addElement("vaso de cerveza = " + formato.format(precioCerveza));
                lista.setModel(modelo);
                total = total + precioCerveza;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 8");
            }
            case "boton9" -> {
                modelo.addElement("vaso de coca-cola = " + formato.format(precioCoca));
                lista.setModel(modelo);
                total = total + precioCoca;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 9");
            }
            case "boton10" -> {
                modelo.addElement("vaso de fanta = " + formato.format(precioFanta));
                lista.setModel(modelo);
                total = total + precioFanta;
                label_Total.setText("Total: " + formato.format(total));
                JOptionPane.showMessageDialog(null, "Has Seleccionado boton 10");
            }
            case "reinicio" -> {
                modelo.clear();
                modeloPrecio.clear();
                total = 0;
                label_Total.setText("Total: " + formato.format(total));
                tArea_coment.setText(" ");
                JOptionPane.showMessageDialog(null, "Has Seleccionado Reinicio");
            }
            default -> {
            }

        }

    }

    //////////crearemos un metodo que nos permita crear y establecer un boton para reiniciar los balores de la comanda//////
    private void reiniciar() {

        reinicio.setBounds(1100, 10, 200, 30);
        panel_Superior.add(reinicio);
        reinicio.setFont(new Font("JetBrains Mono", Font.ITALIC, 20));

    }

}
