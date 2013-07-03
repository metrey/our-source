import java.awt.Container;
import java.io.File;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.HashMap;

import javax.swing.JFrame;

import bsh.This;

import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.swing.JRViewer;

/**
 * 
 */

/**
 * @author sok.pongsametrey
 *
 */
public class MyiReportWinViewer extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = -4526623038138201097L;

	/**
	 * 
	 */
	public MyiReportWinViewer(String fileName, HashMap<String, String> parameter)
	{
		super("View Report");
		try {

			/*
			 * load the required JDBC driver and create the connection here
			 * JDBC-ODBC Bridge Driver is used
			 */
			//Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
			//Connection con = DriverManager.getConnection("jdbc:odbc:DataSourceName");

			// Way 1
			/*
			 * JasperDesign jasperDesign =
			 * JasperManager.loadXmlDesign(fileName); JasperReport jasperReport
			 * = JasperCompileManager.compileReport(jasperDesign); JasperPrint
			 * print = JasperFillManager.fillReport(jasperReport, parameter,
			 * con);
			 */

			// Way 2
			/*
			 * JasperReport jasperReport =
			 * JasperCompileManager.compileReport(fileName); JasperPrint print =
			 * JasperFillManager.fillReport(jasperReport, parameter, con);
			 */

			/*
			 * Way 3 (Here the parameter file should be in .jasper extension
			 * i.e., the compiled report)
			 */
			System.out.println(fileName);
			JasperPrint print = JasperFillManager.fillReport(fileName,
					parameter);

			JRViewer viewer = new JRViewer(print);

			Container c = getContentPane();
			c.add(viewer);
		} catch (JRException jre) {
			jre.printStackTrace();
		} 

		setBounds(10,10,600,500);
		setDefaultCloseOperation(DISPOSE_ON_CLOSE);


		}

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		/* A sample calling */
		//String path = MyiReportWinViewer.class.getResource("/report1.jrxml").getPath();
		String path = "D:/www/research/ireportKhmerUnicode/report1.jrxml";
		String jasperRpt = "D:/www/research/ireportKhmerUnicode/report1.jasper";
		System.out.println("Loading iReport file from path: " + path);
		

		HashMap<String, String> param = new HashMap<String, String>();
		param.put("reportParameterName", jasperRpt);
		MyiReportWinViewer viewer = new MyiReportWinViewer(path, param);
		viewer.setVisible(true);
	}

}
