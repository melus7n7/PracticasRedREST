const router = require('express').Router();
const usuarios = require('../controllers/usuarios.controller')
const Authorize = require('../middleware/auth.middleware')

router.get('/', Authorize('Administrador'), usuarios.getAll);

router.get('/:email',Authorize('Administrador'), usuarios.get);

router.post('/', Authorize('Administrador'), usuarios.create);

router.put('/:email', Authorize('Administrador'), usuarios.update);

router.delete('/:email', Authorize('Administrador'), usuarios.delete);

module.exports = router