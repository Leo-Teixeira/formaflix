
<div class="center">
        <div class="frame">
            <iframe width="560" height="315" src="https://www.youtube.com/embed/<?= $video['IDENTIFIANTVIDEO']; ?>" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
        </div>
        <div class="stand">
            <?= $video['LIBELLE'] ?>
        </div>
    </div>
    <div class="w-100">
        <div class="container p-3">
        <div class="card card-dark mt-5 p-3">
            <div class="text-light"><?= $video['DESCRIPTION'] ?></div>

            <?php
            if (sizeof($competences) > 0) {
                ?>
                <hr class="dropdown-divider">
                <div>
                    <?php
                    foreach ($competences as $competence) {
                        ?>
                        <span class="badge bg-primary"><?= $competence["LIBELLECOMPETENCE"] ?></span>
                        <?php
                    }
                    ?>
                </div>
                <?php
            }
            ?>
        </div>
        </div>
    </div>
    <div class="container p-3">
        <div class="card-dark mt-5">
            <div class="card-body">
                <form action="./ajouter" method="post" class="add">
                    <div class="input-group ">
                        <input id="texte" name="texte" type="text" class="form-control" placeholder=" proposer un commentaire" aria-label="My new idea" aria-describedby="basic-addon1"/>
                    </div>
                    <div class="rating" style="display: inline-block;">
                        <input type="radio" value="5" name="rating" id="rating-5"/>
                        <label for="rating-5" title="5 stars">★</label>
                        <input type="radio" value="4" name="rating" id="rating-4"/>
                        <label for="rating-4" title="4 stars">★</label>
                        <input type="radio" value="3" name="rating" id="rating-3"/>
                        <label for="rating-3" title="3 stars">★</label>
                        <input type="radio" value="2" name="rating" id="rating-2"/>
                        <label for="rating-2" title="2 stars">★</label>
                        <input type="radio" value="1" name="rating" id="rating-1"/>
                        <label for="rating-1" title="1 star">★</label>
                    </div>
                    <div class="text-light">
                        <button type="submit">Envoyer le commentaire</button>
                    </div>
                </form>

            </div>
        </div>
    </div>
</div>




