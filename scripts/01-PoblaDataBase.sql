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


--- TABLA Cliente ---
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Juan Mario','Caceres','Mellado','01/01/2000','abc@abc.cl','abc123','+56987654321',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Teresa','Goñi','Navarrete','18/03/1980','teresagn@correo.cl','clave123','+56967617748',getdate(),1,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Loreley','Baca','Benavides','10/09/1985','loreleyb@rhyta.cl','oOhie0xei','+56922943670',getdate(),01,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Gillermina','Mascarenas','Paz','18/03/1980','guillemasca@correo.cl','gie3puV3','+56915707692',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Fulgencio','Hernádez','Mercado','19/11/1993','fmercado@correo.cl','oow8Eesai','+56979512327',getdate(),0,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Vulpiano','Guillén','Sosa','13/05/1989','vulpix@correo.cl','Riek3aexi0','+56914038159',getdate(),2,1);
INSERT INTO dbo.Cliente (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,correo,clave,telefono,fechaRegistro,advertencias,estado) VALUES ('Maku','Ruvalcaba','Menchaca','11/03/1980','makuruvmen@correo.cl','chaizay9J','+56959250823',getdate(),0,1);


--- TABLA Diseno ---
INSERT INTO dbo.Diseno (descripcion,tiempoEstimado,precio,observacion,urlDiseno,estado) VALUES ('Rombo Pixelado con ribetes azules',10,2000,'Luego de ser pintado debe secarse en 10 minutos.','./fotos/diseno/romboa.jpg',1);


--- TABLA Empleado ---
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Pedro Pablo','Aranguiz','Ortiz','01/01/2095','18349237-3','abc@abc.cl','abc123','+56987654321',getdate(),1,1);
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Maria Mirella','Ponce','Casas','14/05/1984','13487398-1','abcdef@abc.cl','abc123','+56987654321',getdate(),2,1);
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Ramona Ahre','Rivera','Zamudio','01/01/2000','23949819-1','ramri@correo.cl','beehei3Xie','+56985990224',getdate(),2,1);
INSERT INTO dbo.Empleado (nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento,rut,correo,clave,telefono,fechaRegistro,perfil,estado) VALUES ('Ana Aureo','Varela','Jurado','27/02/1991','21430082-6','anitavarelaj@correo.cl','noa7Hee1','+56989323824',getdate(),2,1);


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
