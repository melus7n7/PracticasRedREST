const { bitacora } = require('../models')
let self = {}

self.get = async function(req, res){
    const id = req.params.id;
    if(id == null)
        return res.status(400).send()
    
    let data = await bitacora.findByPk(id, { attributes: [['id', 'bitacoraId'], 'titulo', 'descripcion']})

    if(data){
        return res.status(200).json(data)
    }else{
        return res.status(404).send()
    }
}

self.getAll = async function(req, res){
    let data = await bitacora.findAll({ attributes: [['id', 'bitacoraId'], 'titulo', 'descripcion']})
    return res.status(200).json(data)
}

module.exports = self