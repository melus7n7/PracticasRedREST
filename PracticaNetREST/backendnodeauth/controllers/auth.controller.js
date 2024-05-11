const bcrypt = require('bcrypt')
const { usuario, rol, Sequelize } = require('../models')
const { GeneraToken, TiempoRestanteToken } = require('../services/jwttoken.services')

let self = {}

self.login = async function (req, res){
    try{
        const email = req.body.username
        let data = await usuario.findOne({
            where: { email: email},
            raw: true,
            attributes: [ 'id', 'email', 'nombre', 'passwordhash', [Sequelize.col('rol.nombre'), 'rol']],
            include: { model: rol, attributes: []}
        })

        if(data === null)
            return res.status(401).json({ mensaje: 'Usuario o contraseña incorrectos. '})

        const password = req.body.password
        const passwordMatch = await bcrypt.compare(password, data.passwordhash)

        if(!passwordMatch){
            return res.status(401).json({ mensaje: 'Usuario o contraseña incorrectos '})
        }

        token = GeneraToken(data.email, data.nombre, data.rol)

        return res.status(200).json({
            email:data.email,
            nombre: data.nombre,
            rol: data.rol,
            jwt: token
        })
    }catch(error){
        return res.status(500)
    }
}

self.tiempo = async function (req, res){
    const tiempo = TiempoRestanteToken(req)
    if(tiempo == null){
        return res.status(404).send()
    }
    return res.status(200).send(tiempo)
}

module.exports = self;