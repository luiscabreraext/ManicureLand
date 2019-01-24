--- TABLA Dedo ---
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MD','Dedo pulgar Mano DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MD','Dedo índice Mano DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MD','Dedo medio Mano DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MD','Dedo anular Mano DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MD','Dedo meñique Mano DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MI','Dedo pulgar Mano IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MI','Dedo índice Mano IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MI','Dedo medio Mano IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MI','Dedo anular Mano IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('MI','Dedo meñique Mano IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PD','Dedo pulgar Pie DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PD','Dedo índice Pie DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PD','Dedo medio Pie DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PD','Dedo anular Pie DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PD','Dedo meñique Pie DERECHA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PI','Dedo pulgar Pie IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PI','Dedo índice Pie IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PI','Dedo medio Pie IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PI','Dedo anular Pie IZQUIERDA');
INSERT INTO dbo.Dedo (extremidad,descripción) VALUES ('PI','Dedo meñique Pie IZQUIERDA');


--- TABLA Cliente ---
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Juan Mario','Caceres','Mellado','01/01/2000','abc@abc.cl','e99a18c428cb38d5f260853678922e03','+56987654321',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Teresa','Goni','Navarrete','03/18/1980','teresagn@correo.cl','e99a18c428cb38d5f260853678922e03','+56967617748',getdate(),1,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Loreley','Baca','Benavides','10/09/1985','loreleyb@rhyta.cl','e99a18c428cb38d5f260853678922e03','+56922943670',getdate(),1,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Gillermina','Mascarenas','Paz','03/18/1980','guillemasca@correo.cl','e99a18c428cb38d5f260853678922e03','+56915707692',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Fulgencio','Hernádez','Mercado','11/19/1993','fmercado@correo.cl','e99a18c428cb38d5f260853678922e03','+56979512327',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Vulpiano','Guillén','Sosa','05/13/1989','vulpix@correo.cl','e99a18c428cb38d5f260853678922e03','+56914038159',getdate(),2,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Maku','Ruvalcaba','Menchaca','11/03/1980','makuruvmen@correo.cl','e99a18c428cb38d5f260853678922e03','+56959250823',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Evelio','Rivas','Osorio','10/30/1996','liorivas@correo.cl','e99a18c428cb38d5f260853678922e03','+56977989084',getdate(),1,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Kalen','Ruvalcaba','Covarrubias','06/22/1983','kalirc@correo.cl','e99a18c428cb38d5f260853678922e03','+56913250585',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Saidi','Barrios','Cerda','10/30/1991','saidb@correo.cl','e99a18c428cb38d5f260853678922e03','+56974239952',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Preciosa','Fierro','Montez','02/15/1980','pfierrom@correo.cl','e99a18c428cb38d5f260853678922e03','+56914574852',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Marisel Anisia','Cantú','Chapa','06/12/1996','maricantu@correo.cl','e99a18c428cb38d5f260853678922e03','+56955251792',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Daniela','Quiñones','Candelaria','01/07/1990','daniqcan@correo.cl','e99a18c428cb38d5f260853678922e03','+56946945673',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Brenda','Mojica','Palacios','11/08/1989','brenditadelboom@correo.cl','e99a18c428cb38d5f260853678922e03','+56956522109',getdate(),2,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Katriel','Rosario','Arreola','11/10/1993','katriolaross@correo.cl','e99a18c428cb38d5f260853678922e03','+56906444357',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Taiana','Cavazos','Arellano','09/12/1982','taicaArellano@correo.cl','e99a18c428cb38d5f260853678922e03','+56948028052',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Cristal','Viera','Nevares','06/12/1976','cristalviernez@correo.cl','e99a18c428cb38d5f260853678922e03','+5693133774',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Elsira','Pichardo','Roque','04/12/1994','elsipichro@correo.cl','e99a18c428cb38d5f260853678922e03','+56970288703',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Lidia Alva','Salcido','Guzman','01/01/1997','lidiasal@correo.cl','e99a18c428cb38d5f260853678922e03','+56958709003',getdate(),3,0);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Larry Taciano','Zavala','Duran','01/01/1997','lidiasal2@correo.cl','e99a18c428cb38d5f260853678922e03','+56958709003',getdate(),3,0);


--- TABLA Diseno ---
INSERT INTO dbo.Diseno (descripcion,tiempoEstimado,precio,observacion,urlDiseno,estado) VALUES ('Rombo Pixelado con ribetes azules',10,2000,'Luego de ser pintado debe secarse en 10 minutos.','./fotos/diseno/romboa.jpg',1);


--- TABLA Empleado ---
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Pedro Pablo','Aranguiz','Ortiz','01/01/2095','18349237-3','abc@abc.cl','e99a18c428cb38d5f260853678922e03','+56987654321',getdate(),1,1);
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Maria Mirella','Ponce','Casas','11/05/1984','13487398-1','abcdef@abc.cl','e99a18c428cb38d5f260853678922e03','+56987654321',getdate(),2,1);
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Ramona Ahre','Rivera','Zamudio','01/01/2000','23949819-1','ramri@correo.cl','e99a18c428cb38d5f260853678922e03','+56985990224',getdate(),2,1);
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Ana Aureo','Varela','Jurado','11/02/1991','21430082-6','anitavarelaj@correo.cl','e99a18c428cb38d5f260853678922e03','+56989323824',getdate(),2,1);
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Idalina Nuriya','Toledo','Alcaraz','02/07/1976','24654696-7','idanury@correo.cl','e99a18c428cb38d5f260853678922e03','+56934822214',getdate(),2,1);
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Leonard Joseph','Rosales','Gracia','02/09/1995','18603544-5','leorosales@correo.cl','e99a18c428cb38d5f260853678922e03','+56959063361',getdate(),3,1);


--- TABLA Servicio ---
INSERT INTO dbo.Servicio (descripcion,tiempoEstimado,precio,observacion,codigoColor,estado) VALUES ('Esmalte satinado egipcio',8,5000,'Esmalte de lujo con secado rápido','aa09cf',1);


--- TABLA CatalogoDiseno ---
INSERT INTO dbo.CatalogoDiseno (idDiseno,idManicurista) VALUES (1,2);


--- TABLA CatalogoServicio ---
INSERT INTO dbo.CatalogoServicio (idServicio,idManicurista) VALUES (1,2);


--- TABLA Turno ---
INSERT INTO dbo.Turno (idManicurista,fechaInico,fechaTermino,horaInicio,horaTermino,horaInicioColacion,horaTerminoColacion) VALUES (2,'01/01/2019','12/31/2019','08:00:00.0000','19:00:00.0000','14:00:00.0000','15:00:00.0000');


--- TABLA Reserva ---
INSERT INTO dbo.Reserva (idManicurista,idCliente,tiempoEstimado,precioTotal,observacion,fechaRegistroReserva,fechaReserva,horaLlegada,horaInicioServicio,horaTerminoServicio,estado) VALUES (2,1,60,15000,'Cliente quiere un masaje en sus manos',getdate(),'12/02/2019 15:00',null,null,null,'I');


--- TABLA ReservaDedo ---
INSERT INTO dbo.ReservaDedo (idReserva,idDedo,idDiseno) VALUES (1,1,1);


--- TABLA ReservaServicio ---
INSERT INTO dbo.ReservaServicio (idReserva,idServicio) VALUES (1,1);
