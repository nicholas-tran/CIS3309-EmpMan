//Nicholas Tran && Jimmy Pham
//CIS 3309
//Frank Friedman
//EmpMan Final Project
//4/30/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CIS3309_EmpMan
{   //Form controller class exists to reduce the length of code in the actual form of the project by reducing redundant code blocks into reusable methods
    public class FormControllerClass
    {
        private frmEmpMan f;
        public FormControllerClass(frmEmpMan parentForm)
        {
            f = parentForm;
        }


        // Resets form to initial state after form is loaded or
        //    an add Employee operation is performed
        public static void resetForm(frmEmpMan f)
        {
            //  Reset button components
            f.btnClearEntryForm.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEditUpdate.Enabled = false;
            f.btnFindDisplay.Enabled = false;
            f.btnCreateManager.Enabled = true;
            f.btnCreateManager.Text = "Create Manager";
            f.btnCreateWorker.Enabled = true;
            f.btnCreateWorker.Text = "Create Worker";
            f.btnCreateClient.Enabled = true;
            f.btnCreateClient.Text = "Create Client";


            // Reset group components
            f.grpControl.Enabled = false;
            f.grpCreate.Enabled = false;
            f.grpOptions.Enabled = false;

        } // end resetForm


        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(frmEmpMan f)
        {
            clear(f);
            f.btnFindDisplay.Enabled = false;
            f.btnDelete.Enabled = false;
            f.btnEditUpdate.Enabled = false;
        }  // end formAddMode


        // Enable/disable buttons when not in edit mode
        public static void activateAddButtons(frmEmpMan f)
        {
            f.btnCreateManager.Enabled = true;
            f.btnCreateWorker.Enabled = true;
            f.btnCreateClient.Enabled = true;
        }  // end activateAddButtons


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(frmEmpMan f)
        {
            f.btnCreateManager.Enabled = false;
            f.btnCreateWorker.Enabled = false;
            f.btnCreateClient.Enabled = false;
        }  // end deactivateAddButtons


        //  Enables Employee textboxes and highlights the Person groupbox
        public static void activatePerson(frmEmpMan f)
        {
            f.lblControlPerson.Enabled = true;
            f.lblControlPersonID.Enabled = true;
            f.lblControlPersonName.Enabled = true;
            f.lblControlPersonBirthDate.Enabled = true;
            f.txtControlPersonID.Enabled = true;
            f.txtControlPersonName.Enabled = true;
            f.txtControlPersonBirthDate.Enabled = true;
        }  // end activatePerson


        //  Enables Employee textboxes and highlights the Employee groupbox
        public static void activateEmployee(frmEmpMan f)
        {
            activatePerson(f);
            f.lblControlEmployee.Enabled = true;
            f.lblControlEmployeeJobTitle.Enabled = true;
            f.txtControlEmployeeJobTitle.Enabled = true;
        }  // end ActivateEmployee


        // Enables Employee textboxes and highlights the Client groupbox
        public static void activateClient(frmEmpMan f)
        {
            activatePerson(f);
            f.lblControlClient.Enabled = true;
            f.lblControlClientType.Enabled = true;
            f.txtControlClientType.Enabled = true;
            f.txtControlClientType.Clear();
        }  // end activateClient


        // Enables Manager textboxes and highlights the Manager groupbox
        public static void activateManager(frmEmpMan f)
        {
            activateEmployee(f);   // Employee must be activated too
            f.lblControlManager.Enabled = true;
            f.lblControlManagerBonus.Enabled = true;
            f.lblControlManagerSalary.Enabled = true;
            f.txtControlManagerSalary.Enabled = true;
            f.txtControlManagerBonus.Enabled = true;
        }  // end activateManager


        // Enables Worker textboxes and highlights the Worker groupbox
        public static void activateWorker(frmEmpMan f)
        {
            activateEmployee(f);  // Employee must be activated too
            f.lblControlWorker.Enabled = true;
            f.lblControlWorkerHourlyPay.Enabled = true;
            f.txtControlWorkerHourlyPay.Enabled = true;
        }  // end activateWorker


        // Disables Person textboxes and highlights the Person groupbox
        public static void deactivatePerson(frmEmpMan f)
        {
            deactivateEmployee(f);   // Must deactivate Employee too
            deactivateClient(f);     // Must deactivate Client too
            f.lblControlPerson.Enabled = false;
            f.lblControlPersonID.Enabled = false;
            f.lblControlPersonName.Enabled = false;
            f.lblControlPersonBirthDate.Enabled = false;
            f.txtControlPersonID.Enabled = false;
            f.txtControlPersonName.Enabled = false;
            f.txtControlPersonBirthDate.Enabled = false;
            f.txtControlPersonID.Clear();
            f.txtControlPersonName.Clear();
            f.txtControlPersonBirthDate.Clear();
        }  // end deactivatePerson


        // Disables Employee textboxes and highlights the Employee groupbox
        public static void deactivateEmployee(frmEmpMan f)
        {
            deactivateManager(f);   // Must deactivate Manager too
            deactivateWorker(f);    // Must deactivate Worker too
            f.lblControlEmployee.Enabled = false;
            f.lblControlEmployeeJobTitle.Enabled = false;
            f.txtControlEmployeeJobTitle.Enabled = false;
            f.txtControlEmployeeJobTitle.Clear();
        }  // end deactivateEmployee


        // Disables Client textboxes and highlights the Client groupbox
        public static void deactivateClient(frmEmpMan f)
        {
            f.lblControlClient.Enabled = false;
            f.lblControlClientType.Enabled = false;
            f.txtControlClientType.Enabled = false;
            f.txtControlClientType.Clear();
        }  // end deactivateClient


        // Disables Manager textboxes and highlights the Manager groupbox
        public static void deactivateManager(frmEmpMan f)
        {
            f.lblControlManager.Enabled = false;
            f.lblControlManagerBonus.Enabled = false;
            f.lblControlManagerSalary.Enabled = false;
            f.txtControlManagerSalary.Enabled = false;
            f.txtControlManagerBonus.Enabled = false;
            f.txtControlWorkerHourlyPay.Enabled = false;
        }  // end deactivateManager


        // Disables Worker textboxes and highlights the Worker groupbox
        public static void deactivateWorker(frmEmpMan f)
        {
            f.lblControlWorker.Enabled = false;
            f.lblControlWorkerHourlyPay.Enabled = false;
            f.txtControlWorkerHourlyPay.Enabled = false;
        }  // end deativateWorker

        public static void enableDisplay(frmEmpMan f)
        {

            f.txtControlClientType.Enabled = false;
            f.txtControlEmployeeJobTitle.Enabled = false;
            f.txtControlManagerBonus.Enabled = false;
            f.txtControlManagerSalary.Enabled = false;
            f.txtControlPersonBirthDate.Enabled = false;
            f.txtControlPersonID.Enabled = false;
            f.txtControlPersonName.Enabled = false;
            f.txtControlWorkerHourlyPay.Enabled = false;

        }

        // Clear all textboxes on the form
        public static void clear(frmEmpMan f)
        {
            activateAddButtons(f);
            f.txtControlPersonName.Text = "";
            f.txtControlPersonBirthDate.Text = "";
            f.txtControlPersonID.Text = "";
            f.txtControlClientType.Text = "";
            f.txtControlEmployeeJobTitle.Text = "";
            f.txtControlManagerSalary.Text = "";
            f.txtControlManagerBonus.Text = "";
            f.txtControlWorkerHourlyPay.Text = "";

            f.txtControlPersonName.Enabled = true;
            f.txtControlPersonBirthDate.Enabled = true;
            f.txtControlPersonID.Enabled = true;
            f.txtControlClientType.Enabled = true;
            f.txtControlEmployeeJobTitle.Enabled = true;
            f.txtControlManagerSalary.Enabled = true;
            f.txtControlManagerBonus.Enabled = true;
            f.txtControlWorkerHourlyPay.Enabled = true;
            f.lblControlClient.Enabled = true;
            f.lblControlClientType.Enabled = true;
            f.lblControlEmployee.Enabled = true;
            f.lblControlEmployeeJobTitle.Enabled = true;
            f.lblControlManager.Enabled = true;
            f.lblControlManagerBonus.Enabled = true;
            f.lblControlManagerSalary.Enabled = true;
            f.lblControlPerson.Enabled = true;
            f.lblControlPersonBirthDate.Enabled = true;
            f.lblControlPersonID.Enabled = true;
            f.lblControlPersonName.Enabled = true;
            f.lblControlsDesc.Enabled = true;
            f.lblControlWorker.Enabled = true;
            f.lblControlWorkerHourlyPay.Enabled = true;
            f.lblCreateDesc.Enabled = true;
            f.lblTitle.Enabled = true;
        } // end Clear
    }  // end FormController class
}  // end namespace


