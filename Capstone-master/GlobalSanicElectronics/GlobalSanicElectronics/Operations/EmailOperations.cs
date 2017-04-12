using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    class EmailOperations
    {
        //Method to email user with information regarding there newly created user
        public static void UserCreatedEmail(string email, string username, string DOB, string address, string city, string state, string zip)
        {
            //Way to send user an email with all account information and confirm that there account is created.
            var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress(email, username);
            const string fromPassword = "GSEPassword";
            const string subject = "Thank you for joining Global Sanic Electronics!";
            string body = "Hello " + username + " thank you for joining Global Sanic Electronics." + "\n\n" +
                "To ensure all your information is correct, this is what you entered upon account creation. If any of this information needs to be updated, please do not hesitate to email us back" + "\n\n" +
                "Email = " + email + "\n" +
                "Date of Birth = " + DOB + "\n" +
                "Street Address = " + address + "\n" +
                "City = " + city + "\n" +
                "State = " + state + "\n" +
                "Zip = " + zip + "\n\n" +
                "Thank you once again for joining Global Sanic Electronics! We hope you enjoy your stay!";

            //Area to establish a connection with the smtpclient and put the host and port number down
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        //Method to email user with there newly created order with information regarding the order
        public static void UserOrderCreated(string email, string username, double price, double number, Cart userCart)
        {
            //Way to send user an email with all the purchase information and give them there order number
            var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress(email, username);
            const string fromPassword = "GSEPassword";
            const string subject = "Thank you for your purchase from Global Sanic Electronics!";
            string body = "Hello " + username + " thank you for your recent purchase from Global Sanic Electronics!" + "\n\n" +
                "Here is all the information for your recent purchase!" + "\n\n" +
                "Price = $" + price + "\n" +                
                "Order number = " + number + "\n" +
                "Once again, thank you for your purchase from Global Sanic Electronics!" + "\n\n" +
                "This is what you ordered" + "\n";

            foreach (ConsoleDirectory item in userCart.Consoles)
            {
                body += "Console : " + item.Brand + " with a price of " + item.Price + "\n";
            }

            foreach (ComputerDirectory item in userCart.Computers)
            {
                body += "Computer : " + item.Brand + " with a price of " + item.Price + "\n";
            }

            foreach (TabletDirectory item in userCart.Tablets)
            {
                body += "Tablet : " + item.Brand + " with a price of " + item.Price + "\n";
            }

            foreach  (TelevisionDirectory item in userCart.Televisions)
            {
                body += "Television : " + item.Brand + " with a price of " + item.Price + "\n";
            }

            //Area to establish a connection with the smtpclient and put the host and port number down
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        //Method to email the company to allow the user to email feedback or problems about the application
        public static void FeedBackEmail(string email, string contactScreenUsernameHolder, TextBox feedbackTextBox)
        {
            var fromUSAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            const string fromUSPassword = "GSEPassword";
            const string updateSubject = "User Feedback";
            string updateBody = "User : " + contactScreenUsernameHolder + " has sent the following feedback, \n\n" +
                feedbackTextBox.Text;

            //Establis a connection with the smtpclient and put the host and port number down
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromUSAddress.Address, fromUSPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromUSAddress, toAddress)
            {
                Subject = updateSubject,
                Body = updateBody
            })
            {
                smtp.Send(message);
            }
        }

        //Method to email the user and company when the user has requested a repair and to email the company to let them know
        public static void RepairRequested(string email, string requestRepaireFormUsername)
        {
            //Get the customers email
            string selectEmailSQL = "SELECT Email FROM CustomerInformation Where Username= '" + requestRepaireFormUsername + "'";
            SqlCommand command = new SqlCommand(selectEmailSQL, DatabaseOperations.sqlConnectionLink);

            try
            {
                DatabaseOperations.sqlConnectionLink.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email = (reader["Email"].ToString());
                    }
                }
            }
            finally
            {
                DatabaseOperations.sqlConnectionLink.Close();
            }

            //Send user an email to let them know there Repair Status has been updated
            var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toUserAddress = new MailAddress(email, requestRepaireFormUsername);
            const string fromPassword = "GSEPassword";
            const string subject = "Update on your Repair";
            string body = "Hello " + requestRepaireFormUsername + "\n\n" +
                "In order to process or repair your item, we are going to need you to ship your item back to the facility. If you could please send your item back to this address \n\n" +
                "Global Sanic Electronics" + "\n" +
                "8785 Windfall St \n" +
                "Whitehall, PA 18052" + "\n\n" +
                "We appreciate your assistance with this and we will repair and send back your item as quickly as possible.";

            //Establis a connection with the smtpclient and put the host and port number down
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromAddress, toUserAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

            //Send user an email to let them know there Repair Status has been updated
            var fromUSAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            const string fromUSPassword = "GSEPassword";
            const string updateSubject = "User Requested Refund";
            string updateBody = "User : " + requestRepaireFormUsername + " has requested a repair";

            //Establis a connection with the smtpclient and put the host and port number down
            var _smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromUSPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromUSAddress, toAddress)
            {
                Subject = updateSubject,
                Body = updateBody
            })
            {
                smtp.Send(message);
            }
        }

        //Method to email the user and company when the user has requested a refund and to email the company to let them know
        public static void RefundRequested(string email, string refundRequestScreenUsername)
        {
            //Get the customers email
            string selectEmailSQL = "SELECT Email FROM CustomerInformation Where Username= '" + refundRequestScreenUsername + "'";
            SqlCommand command = new SqlCommand(selectEmailSQL, DatabaseOperations.sqlConnectionLink);

            try
            {
                DatabaseOperations.sqlConnectionLink.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email = (reader["Email"].ToString());
                    }
                }
            }
            finally
            {
                DatabaseOperations.sqlConnectionLink.Close();
            }

            //Send user an email to let them know there Repair Status has been updated
            var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toUserAddress = new MailAddress(email, refundRequestScreenUsername);
            const string fromPassword = "GSEPassword";
            const string subject = "Update on your Refund";
            string body = "Hello " + refundRequestScreenUsername + "\n\n" +
                "In order to process or refund your item, we are going to need you to ship your item back to the facility. If you could please send your item back to this address \n\n" +
                "Global Sanic Electronics" + "\n" +
                "8785 Windfall St \n" +
                "Whitehall, PA 18052" + "\n\n" +
                "We appreciate your assistance with this and we will refudn your money as soon as we get the item back.";

            //Establis a connection with the smtpclient and put the host and port number down
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromAddress, toUserAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

            //Send user an email to let them know there Repair Status has been updated
            var fromUSAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            const string fromUSPassword = "GSEPassword";
            const string updateSubject = "User Requested Refund";
            string updateBody = "User : " + refundRequestScreenUsername + " has requested a refund";

            //Establis a connection with the smtpclient and put the host and port number down
            var _smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromUSPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromUSAddress, toAddress)
            {
                Subject = updateSubject,
                Body = updateBody
            })
            {
                smtp.Send(message);
            }
        }

        //Method to email the user with information regarding a token that they can use to change there password
        public static void ForgotPassword(TextBox emailTextBox, TextBox usernameTextBox, double temporaryPassword)
        {
            //Way to send user an email with all account information and confirm that there account is created.
            var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
            var toAddress = new MailAddress(emailTextBox.Text, usernameTextBox.Text);
            const string fromPassword = "GSEPassword";
            const string subject = "Password Reset";
            string body = "Hello " + usernameTextBox.Text + "\n\n" +
                "Here is your temporary password : " + temporaryPassword + "\n\n" +
                "In order to reset your password, you must log in with that password and follow the on screen instructions followed";

            //Area to establish a connection with the smtpclient and put the host and port number down
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            //Area to actually send the message out to the user
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        //Method to email the user with information regarding there new repair status
        public static void RepairStatus(string repairStatus, string email, TextBox usernameTextBox, ComboBox repairStatusComboBox)
        {
            //Get the customers email
            string selectEmailSQL = "SELECT Email FROM CustomerInformation Where Username= '" + usernameTextBox.Text + "'";
            SqlCommand command = new SqlCommand(selectEmailSQL, DatabaseOperations.sqlConnectionLink);

            try
            {
                DatabaseOperations.sqlConnectionLink.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email = (reader["Email"].ToString());
                    }
                }
            }
            finally
            {
                DatabaseOperations.sqlConnectionLink.Close();
            }


            if (repairStatus == "Two")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Your order has been received by Global Sanic Electronics" + "\n\n" +
                    "We will continue to update you on the status of your repair!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (repairStatus == "Three")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, The problem is currently being investigated" + "\n" +
                    "We will continue to update you on the status of your repair!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (repairStatus == "Four")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Problem has been found and is being repaired" + "\n" +
                    "We will continue to update you on the status of your repair!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (repairStatus == "Five")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Order has been successfully repaired and is being shipped back" + "\n" +
                    "We will continue to update you on the status of your repair!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (repairStatus == "Six")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Repair";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + repairStatusComboBox.SelectedItem + "\n" +
                    "This means, Order has been shipped back to you" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
        }

        //Method to email the user with information regarding there new refund status
        public static void RefundStatus(string refundStatus, string email, TextBox usernameTextBox, ComboBox refundStatusComboBox)
        {
            //Get the customers email
            string selectEmailSQL = "SELECT Email FROM CustomerInformation Where Username= '" + usernameTextBox.Text + "'";
            SqlCommand command = new SqlCommand(selectEmailSQL, DatabaseOperations.sqlConnectionLink);

            try
            {
                DatabaseOperations.sqlConnectionLink.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email = (reader["Email"].ToString());
                    }
                }
            }
            finally
            {
                DatabaseOperations.sqlConnectionLink.Close();
            }


            if (refundStatus == "Two")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Refund";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + refundStatusComboBox.SelectedItem + "\n" +
                    "This means, Your order has been received by Global Sanic Electronics" + "\n" +
                    "We will continue to update you on the status of your refund!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (refundStatus == "Three")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Refund";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + refundStatusComboBox.SelectedItem + "\n" +
                    "This means, Your refund is currently being processed by Global Sanic Electronics" + "\n" +
                    "We will continue to update you on the status of your refund!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (refundStatus == "Four")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Refund";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + refundStatusComboBox.SelectedItem + "\n" +
                    "This means, Your refund has been transacted from Global Sanic Electronics to your bank provider" + "\n" +
                    "We will continue to update you on the status of your refund!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (refundStatus == "Five")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Refund";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your repair status has updated to : " + refundStatusComboBox.SelectedItem + "\n" +
                    "This means, Your refund should be complete now" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
        }

        //Method to email the user with information regarding there new delivery status
        public static void DeliveryStatus(string deliveryStatus, string email, TextBox usernameTextBox, ComboBox deliveryComboBox)
        {
            //Get the customers email
            string selectEmailSQL = "SELECT Email FROM CustomerInformation Where Username= '" + usernameTextBox.Text + "'";
            SqlCommand command = new SqlCommand(selectEmailSQL, DatabaseOperations.sqlConnectionLink);

            try
            {
                DatabaseOperations.sqlConnectionLink.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email = (reader["Email"].ToString());
                    }
                }
            }
            finally
            {
                DatabaseOperations.sqlConnectionLink.Close();
            }


            if (deliveryStatus == "Two")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Delivery";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your delivery status has updated to : " + deliveryComboBox.SelectedItem + "\n" +
                    "This means, Your order is being packed up to ship" + "\n\n" +
                    "We will continue to update you on the status of your delivery!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (deliveryStatus == "Three")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Delivery";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your delivery status has updated to : " + deliveryComboBox.SelectedItem + "\n" +
                    "This means, your order has been shipped" + "\n" +
                    "We will continue to update you on the status of your delivery!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (deliveryStatus == "Four")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Delivery";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your delivery status has updated to : " + deliveryComboBox.SelectedItem + "\n" +
                    "This means, your order has been delivered to local mailing facility" + "\n" +
                    "We will continue to update you on the status of your delivery!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (deliveryStatus == "Five")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Delivery";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your delivery status has updated to : " + deliveryComboBox.SelectedItem + "\n" +
                    "This means, Your order is out for delivery" + "\n" +
                    "We will continue to update you on the status of your delivery!" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            else if (deliveryStatus == "Six")
            {
                //Send user an email to let them know there Repair Status has been updated
                var fromAddress = new MailAddress("GlobalSanicElectronics@gmail.com", "Global Sanic Electronics");
                var toAddress = new MailAddress(email, usernameTextBox.Text);
                const string fromPassword = "GSEPassword";
                const string subject = "Update on your Delivery";
                string body = "Hello " + usernameTextBox.Text + "\n\n" +
                    "Your delivery status has updated to : " + deliveryComboBox.SelectedItem + "\n" +
                    "This means, Order has been shipped to you" + "\n" +
                    "Sincerly, \n\n\n\n" +
                    "Global Sanic Electronics";

                //Establis a connection with the smtpclient and put the host and port number down
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                //Area to actually send the message out to the user
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}
