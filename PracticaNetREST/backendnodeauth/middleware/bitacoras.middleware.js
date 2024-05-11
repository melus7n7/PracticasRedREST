const { bitacora } = require('../models')

const RegistrarEnBitacora = (titulo, descripcion) =>{
    return async(req, res, next) => {
        console.log(req.body)
        try{
            let data = await bitacora.create({
                titulo: titulo,
                descripcion: descripcion
            })
            next()
        }catch(error){
            res.status(500).json()
        }
    }
}

module.exports = RegistrarEnBitacora;