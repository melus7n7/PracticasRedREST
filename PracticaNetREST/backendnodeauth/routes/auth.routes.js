const router = require('express').Router()
const auth = require('../controllers/auth.controller')
const RegistrarEnBitacora = require('../middleware/bitacoras.middleware')

router.post('/', RegistrarEnBitacora("Autorización", "POST-LOGIN"), auth.login)

router.get('/tiempo', auth.tiempo)

module.exports = router